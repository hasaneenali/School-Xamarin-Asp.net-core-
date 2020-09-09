using GalaSoft.MvvmLight.Command;
using Plugin.Media;
using Plugin.Media.Abstractions;
using School.Common.Model;
using School.Mobile.Models;
using School.Mobile.Services;
using School.Mobile.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace School.Mobile.ViewModel
{
   public class TeacherViewModel: BaseViewModel
    {
        public Teacher TheSelectedGender { get; set; }

        private DataService dataService;

        private MediaFile file;
        public string Name { get; set; }

        

        public int Age { get; set; }



        public string Mobile { get; set; }

        private ImageSource imageSource;

       
        public ImageSource ImageSource
        {
            get => imageSource;
            set
            {
                imageSource = value;
                NotifyPropertyChanged();
            }
        }


        private List<TeachrData> listData2 { get; set; }


        public List<TeachrData> ListData2
        {
            get { return listData2; }
            set
            {
                listData2 = value;
                NotifyPropertyChanged();

            }
        }
        

        private List<Teacher> _list { get; set; }


        public List<Teacher> ListData
        {
            get { return _list; }
            set
            {
                _list = value;
                NotifyPropertyChanged();

            }
        }

        private async void AllData()
        {
            IsLoading = true;
            ListData = await ApiService.GetTeachers();
            IsLoading = false;
        }


        public TeacherViewModel()
        {

           // AllData();
            dataService = new DataService();
            this.ImageSource = "noImage";
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(AllData);
            }
        }

        public ICommand ChangeImageCommand => new RelayCommand(this.ChangeImage);
        private async void ChangeImage()
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
                this.ImageSource = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    CurrentImageBase64 = GetBase64(file.GetStream());
                    return stream;
                });
            }
        }

        private string CurrentImageBase64 { set; get; }

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

        public ICommand SaveCommand => new RelayCommand(this.Save);

        private async void Save()
        {
            if (string.IsNullOrEmpty(Name))
            {
                await Application.Current.MainPage.DisplayAlert("الرجاء", "عدم ترك الاسم فارغ", "الاسم");
                return;
            }

            if (string.IsNullOrEmpty(Age.ToString()))
            {
                await Application.Current.MainPage.DisplayAlert("الرجاء", "عدم ترك الاسم فارغ", "الاسم");
                return;
            }


            if (string.IsNullOrEmpty(Mobile))
            {
                await Application.Current.MainPage.DisplayAlert("الرجاء", "عدم ترك الاسم فارغ", "الاسم");
                return;
            }



            if (string.IsNullOrEmpty(Preferences.Get("MaterialId", string.Empty)))
            {
                await Application.Current.MainPage.DisplayAlert("الرجاء", "عدم ترك الاختصاص فارغ", "الاسم");
                return;
            }


            byte[] imageArray = null;
            if (this.file != null)
            {
                imageArray = FilesHelper.ReadFully(this.file.GetStream());
            }

            IsRunning = true;
            Teacher teacher = new Teacher();
            teacher.Name = Name;
            teacher.Age = Age;
            teacher.Mobile = Mobile;
            string MaterialId = Preferences.Get("MaterialId", string.Empty);
            teacher.MaterialId =Convert.ToInt32(MaterialId);
            teacher.ImageArray = imageArray;
           
            await ApiService.AddTeachers(teacher);
             Preferences.Set("MaterialId", string.Empty);
            IsRunning = false;
            await Application.Current.MainPage. DisplayAlert("الاضاقه", "تمت الاضافه بنجاح", "نعم");
            await Application.Current.MainPage.Navigation.PushAsync(new TeachersPage());

        }


        

        public ICommand UploadData => new RelayCommand(this.Upload);

        private async void Upload()
        {
            ListData2 = await dataService.AllGetTeachrData();
          
        }

        public ICommand DataCommand => new RelayCommand(this.Data);

        private async void Data()
        {

            //byte[] imageArray = null;
            //if (this.file != null)
            //{
            //    imageArray = FilesHelper.ReadFully(this.file.GetStream());
            //}

            IsRunning = true;
            TeachrData teacher = new TeachrData();
            teacher.Name = Name;
            teacher.Age = Age;
            teacher.Mobile = Mobile;
            //teacher.ImageArray = imageArray;
            teacher.ImageUrl = CurrentImageBase64;
            await dataService.Insert(teacher);
            IsRunning = false;
            await Application.Current.MainPage.DisplayAlert("الاضاقه", "تمت الاضافه بنجاح", "نعم");
            await Application.Current.MainPage.Navigation.PushAsync(new TeachersPage());

            
        }

        public ICommand EditCommand => new RelayCommand(Edit);
         private async  void Edit()
        {
            if (string.IsNullOrEmpty(TheSelectedGender.Name))
            {
                await Application.Current.MainPage.DisplayAlert("الرجاء", "عدم ترك الاسم فارغ عندالتعديل", "الاسم");
                return;
            }

            if (string.IsNullOrEmpty(TheSelectedGender.Age.ToString()))
            {
                await Application.Current.MainPage.DisplayAlert("الرجاء", "عدم ترك الاسم فارغ عندالتعديل", "الاسم");
                return;
            }


            if (string.IsNullOrEmpty(TheSelectedGender.Mobile))
            {
                await Application.Current.MainPage.DisplayAlert("الرجاء", "عدم ترك الاسم فارغ عندالتعديل", "الاسم");
                return;
            }

            byte[] imageArray = null;
            if (this.file != null)
            {
                imageArray = FilesHelper.ReadFully(this.file.GetStream());
            }

            Teacher teacher = new Teacher();
            teacher.Name = TheSelectedGender.Name;
            teacher.Age = TheSelectedGender.Age;
            teacher.Mobile = TheSelectedGender.Mobile;
            teacher.Id = TheSelectedGender.Id;
            string MaterialId = Preferences.Get("MaterialId", string.Empty);
            teacher.MaterialId = Convert.ToInt32(MaterialId);
           teacher.ImageArray = imageArray;
            await ApiService.EditTeachers(TheSelectedGender.Id,teacher);
            Preferences.Set("MaterialId", string.Empty);
            await Application.Current.MainPage.DisplayAlert("الاضاقه", "تمت الاضافه بنجاح", "نعم");
            await Application.Current.MainPage.Navigation.PushAsync(new TeachersPage());

        }


        public ICommand DeleteCommand => new RelayCommand(Delete);

        private async void Delete()
        {
            IsRunning = true;
            await ApiService.DeleteTeachers(TheSelectedGender.Id);
            IsRunning = false;
            await Application.Current.MainPage.DisplayAlert("الاضاقه", "تمت الاضافه بنجاح", "نعم");
            await Application.Current.MainPage.Navigation.PushAsync(new TeachersPage());
        }
    }
}
