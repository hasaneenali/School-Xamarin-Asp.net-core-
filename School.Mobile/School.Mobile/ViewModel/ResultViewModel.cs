
using GalaSoft.MvvmLight.Command;
using School.Mobile.Models;
using School.Mobile.Services;
using System.Collections.Generic;
using System.Windows.Input;

namespace School.Mobile.ViewModel
{
    public class ResultViewModel:BaseViewModel
    {
        public string totalAll { get; set; }

        public string TotalAll {
            get {return totalAll; }

            set {
                totalAll = value;
                NotifyPropertyChanged();
            } 
        
        
        }


        public List<Result> result { get; set; }


        public List<Result> Result 
        
        {
            get 
            { return result; }


            set 
            {
                result = value;
                
                NotifyPropertyChanged();
            } 
        
        
        }


        public async void AllResults()
        {
            IsLoading = true;
            var connection = await ApiService.CheckConnection("https://school-web.conveyor.cloud/");

            if (connection==true)
            {
                Result = await ApiService.GetResults();


                //foreach (var item in Result)
                //{
                //    if (item.Total>0)
                //    {
                //        TotalAll = "ناجح";
                //    }
                //}
            }
            IsLoading = false;
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(AllData);
            }
        }

        private async void AllData()
        {
            IsLoading = true;
            Result = await ApiService.GetResults();
            IsLoading = false;
        }

        public   ResultViewModel()
        {
            AllResults();
            TotalAll = "ناجح";

        }
    }
}
