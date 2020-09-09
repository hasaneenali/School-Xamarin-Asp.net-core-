using School.Common.Model;
using School.Mobile.Models;
using School.Mobile.Services;
using School.Mobile.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace School.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditTeacherPage : ContentPage
    {
        public ObservableCollection<Material> DataCollection;
        public EditTeacherPage(Teacher teacher)
        {
            InitializeComponent();
            var EditViewModel = new TeacherViewModel();
            EditViewModel.TheSelectedGender = teacher;
            DataCollection = new ObservableCollection<Material>();
            GetALLData();
            BindingContext = EditViewModel;
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


        private void PickerMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = sender as Picker;
            var selectedCategory = (Material)picker.SelectedItem;
            EntryMaterialName.Text = selectedCategory.Name;
            string MaterialId = selectedCategory.Id.ToString();
            Preferences.Set("MaterialId", MaterialId);

        }


        private bool _isRunning { get; set; }
        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }
            set
            {
                if (value != _isRunning)
                {
                    _isRunning = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            IsRunning = true;
            int id = Convert.ToInt32(EntryId.Text);
            Teacher teacher = new Teacher();
            teacher.Id = id;
            await ApiService.DeleteTeachers(id);
            IsRunning = false;
            await DisplayAlert("الحذف", "تمت الحذف بنجاح", "نعم");
            await Navigation.PushAsync(new TeachersPage());
        }
    }
}