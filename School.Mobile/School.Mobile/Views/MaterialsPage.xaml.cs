
using School.Mobile.Models;
using School.Mobile.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace School.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterialsPage : ContentPage
    {
        
        public MaterialsPage()
        {
            InitializeComponent();
            BindingContext = new MaterialViewModel();
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddMaterialsPage());
        }

        private async void ListView1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var material = e.Item as Material;
            await Navigation.PushAsync(new EditMaterialsPage(material));
        }

        //private async void GetHotAndNewVehicles()
        //{
        //    MaterialCollection.Clear();
        //    var vehicles = await ApiService.GetMaterials();
        //    foreach (var vehicle in vehicles)
        //    {

        //        MaterialCollection.Add(vehicle);
        //    }
        //    ListViewMaterial.ItemsSource = MaterialCollection;
        //}

        //private async void BtnAdd_Clicked(object sender, EventArgs e)
        //{
        //   await ApiService.AddMaterials(EntryName.Text);
        //   GetHotAndNewVehicles();
        //}
    }
}