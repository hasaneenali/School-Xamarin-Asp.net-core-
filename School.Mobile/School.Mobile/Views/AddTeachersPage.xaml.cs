using ImageToArray;
using Plugin.Media;
using Plugin.Media.Abstractions;
using School.Common.Model;
using School.Mobile.Models;
using School.Mobile.Services;
using School.Mobile.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace School.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTeachersPage : ContentPage
    {
        public ObservableCollection<Material> DataCollection;
        private MediaFile file;
        private DataService dataService;

       

        public AddTeachersPage()
        {
            InitializeComponent();
            DataCollection = new ObservableCollection<Material>();
            dataService = new DataService();
            GetALLData();
            BindingContext = new TeacherViewModel();
        }


        private async void GetALLData()
        {
            var datas = await ApiService.GetMaterials();
            foreach (var data in datas)
            {
                DataCollection.Add(data);
            }
            PickerMaterialName.ItemsSource = DataCollection;
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            byte[] imageArray = null;
            if (this.file != null)
            {
                imageArray = FilesHelper.ReadFully(this.file.GetStream());
            }

            Teacher teacher = new Teacher();
            teacher.Name = EntryName.Text;
            teacher.Age =Convert.ToInt32( EntryAge.Text);
            teacher.Mobile = EntryMobile.Text;
            teacher.MaterialId = 3033;
            teacher.ImageArray = imageArray;
            await ApiService.AddTeachers(teacher);
            await DisplayAlert("الاضاقه", "تمت الاضافه بنجاح", "نعم");
            await Navigation.PushAsync(new TeachersPage());
        }

        private void PickerMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = sender as Picker;
            var selectedCategory = (Material)picker.SelectedItem;
           string MaterialId = selectedCategory.Id.ToString();
            Preferences.Set("MaterialId", MaterialId);
        }

        private string CurrentImageBase64 { set; get; }
        private async void BtnTakePhoto_Clicked(object sender, EventArgs e)
        {
            var current = Plugin.Media.CrossMedia.Current;
            if (current.IsCameraAvailable && current.IsTakePhotoSupported)
            {
                var photo = await current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    CompressionQuality = 70
                });

                image1.Source = ImageSource.FromStream(() =>
                {
                    var stream = photo.GetStream();
                    CurrentImageBase64 = GetBase64(photo.GetStream());
                    photo.Dispose();
                    return stream;
                });

               
            }
        }


        private string GetBase64(Stream stream)
        {
            byte[] array;

            using (MemoryStream memory = new MemoryStream())
            {
                stream.CopyTo(memory);
                array = memory.ToArray();
            }

            return Convert.ToBase64String(array);
        }

        private Stream GetStream(string base64)
        {
            byte[] array = Convert.FromBase64String(base64);

            return new MemoryStream(array);
        }

        private async void dataloca_Clicked(object sender, EventArgs e)
        {
            TeachrData teacher = new TeachrData();
            teacher.Name = EntryName.Text;
            teacher.Age =Convert.ToInt32( EntryAge.Text);
            teacher.Mobile = EntryMobile.Text;
            teacher.ImageUrl = CurrentImageBase64;
            await dataService.Insert(teacher);
          
            await Application.Current.MainPage.DisplayAlert("الاضاقه", "تمت الاضافه بنجاح", "نعم");
            await Application.Current.MainPage.Navigation.PushAsync(new TeachersPage());
        }
    }
}
    
