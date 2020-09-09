
using School.Mobile.Models;
using School.Mobile.Services;
using School.Mobile.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace School.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddMaterialsPage : ContentPage
    {

        private DataService dataService;


        public AddMaterialsPage()
        {
            InitializeComponent();
            dataService = new DataService();
           

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Material material = new Material();
            material.Name = EntryName.Text;
            var connection = await ApiService.CheckConnection("https://school-web.conveyor.cloud/");

            if (!connection)
            {
                await dataService.Insert(material);
            }

            else
            {
                await dataService.Insert(material);

                //  await ApiService.AddMaterials(material);
            }
          
           
            await DisplayAlert("الاضاقه", "تمت الاضافه بنجاح", "نعم");
            await Navigation.PushAsync(new MaterialsPage());
         
        }

       
    }
}