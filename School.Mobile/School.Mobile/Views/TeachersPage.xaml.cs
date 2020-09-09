using School.Common.Model;
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
    public partial class TeachersPage : ContentPage
    {
        public TeachersPage()
        {
            InitializeComponent();
            BindingContext = new TeacherViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTeachersPage());
        }

        private async void ListView1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var teacher = e.Item as Teacher;
            await Navigation.PushAsync(new EditTeacherPage(teacher));
        }
    }
}