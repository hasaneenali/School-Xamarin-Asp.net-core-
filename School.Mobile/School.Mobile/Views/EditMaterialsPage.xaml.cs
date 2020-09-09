
using School.Mobile.Models;
using School.Mobile.Services;
using School.Mobile.ViewModel;
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
    public partial class EditMaterialsPage : ContentPage
    {
      
        public EditMaterialsPage(Material material)
        {
            InitializeComponent();
            var EditViewModel = new MaterialViewModel();
            EditViewModel.TheSelectedGender = material;
            BindingContext = EditViewModel;
        }



        private  async void BtnEdit_Clicked(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(EntryId.Text);
            Material material = new Material();
            material.Name = EntryName.Text;
            material.Id = id;
            await ApiService.EditMaterials(id, material);
            await DisplayAlert("الاضاقه", "تمت التعديل بنجاح", "نعم");
            await Navigation.PushAsync(new MaterialsPage());
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(EntryId.Text);
            Material material = new Material();
            material.Id = id;
            await ApiService.DeleteMaterials(id);
            await DisplayAlert("الحذف", "تمت الحذف بنجاح", "نعم");
            await Navigation.PushAsync(new MaterialsPage());
        }
    }
}