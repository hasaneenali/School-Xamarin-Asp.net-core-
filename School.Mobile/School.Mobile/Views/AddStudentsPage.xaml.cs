using Plugin.Media;
using Plugin.Media.Abstractions;
using School.Mobile.Models;
using School.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace School.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddStudentsPage : ContentPage
    {
        private MediaFile file;
        private string StageSchool;
        public AddStudentsPage()
        {
            InitializeComponent();
        }

        private async void TapImg1_Tapped(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            var source = await Application.Current.MainPage.DisplayActionSheet(
                "Where do you take the picture?",
                "Cancel",
                null,
                "From Gallery",
                "From Camera");

            if (source == "Cancel")
            {
                this.file = null;
                return;
            }

            if (source == "From Camera")
            {
                this.file = await CrossMedia.Current.TakePhotoAsync(
                    new StoreCameraMediaOptions
                    {
                        Directory = "Pictures",
                        Name = "test.jpg",
                        PhotoSize = PhotoSize.Small,
                    }
                );
            }
            else
            {
                this.file = await CrossMedia.Current.PickPhotoAsync();
            }

            

            if (this.file != null)
            {
                Image2.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    return stream;
                });
            }





        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {

            byte[] imageArray = null;
            if (this.file != null)
            {
                imageArray = FilesHelper.ReadFully(this.file.GetStream());
            }

            Student student = new Student
            {
                Name = EntryName.Text,
                Age = Convert.ToInt32(EntryAge.Text),
                Mobile = EntryMobile.Text,
                StageSchool = StageSchool,
                ImageArray = imageArray

            };

            await ApiService.AddStudent(student);

           await DisplayAlert("الاضافه", "تمت", "نعم");

        }

        private void picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            StageSchool = (string)picker.ItemsSource[selectedIndex];

        }
    }
}