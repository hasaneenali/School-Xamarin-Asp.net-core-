using GalaSoft.MvvmLight.Command;
using School.Mobile.Models;
using School.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace School.Mobile.ViewModel
{
    class MaterialViewModel: BaseViewModel
    {

        public Material TheSelectedGender { get; set; }

        private DataService dataService;

        private List<Material> _material { get; set; }

       


        public List<Material> _Material
        {
            get { return _material; }
            set
            {
                _material = value;
                NotifyPropertyChanged();

            }
        }


        public ICommand UploadCommand => new RelayCommand(Upload);

        private async void Upload()
        {
            var connection = await ApiService.CheckConnection("https://school-web.conveyor.cloud/");
            if (connection)
            {
                _Material = await this.dataService.GetAllProducts();
                await dataService.DeleteAllProducts();
                await ApiService.InsertAllMaterial(_Material);

            }
        }

        private async void AllMaterials()
        {
            IsLoading = true;
            var connection = await ApiService.CheckConnection("https://school-web.conveyor.cloud/");

            if (!connection)
            {
            
                _Material = await this.dataService.GetAllProducts();
               
            }

            else
            {

                _Material = await this.dataService.GetAllProducts();
                //_Material = await ApiService.GetMaterials();
                //await dataService.DeleteAllProducts();
                //await dataService.InsertAll(_Material);


            }

           
            IsLoading = false;
        }


       

       


        public    MaterialViewModel()
        {
           dataService = new DataService();
           AllMaterials();
          
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(AllMaterials);
            }
        }
    }
}
