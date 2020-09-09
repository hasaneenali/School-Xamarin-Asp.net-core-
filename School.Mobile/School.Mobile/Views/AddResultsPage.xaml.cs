using School.Mobile.Models;
using School.Mobile.Services;
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
    public partial class AddResultsPage : ContentPage
    {
        public int total;
        public int StudentId;
        public ObservableCollection<Student> DataCollection;

        public AddResultsPage()
        {
            InitializeComponent();
            DataCollection = new ObservableCollection<Student>();
            GetALLData();
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            var result = new Result
            {
             Arabic=Convert.ToInt32(EntryArabic.Text),
             English= Convert.ToInt32(EntryEnglish.Text),
             Maths= Convert.ToInt32(EntryMaths.Text),
             Sociology= Convert.ToInt32(EntrySociology.Text),
             Total= total,
             StudentId= StudentId,
             Success=EntrySuccess.Text
            };

            ApiService.AddResult(result);
        }

        private void EntryArabic_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int Arabic = Convert.ToInt32(EntryArabic.Text);
                int English = Convert.ToInt32(EntryEnglish.Text);
                int Maths = Convert.ToInt32(EntryMaths.Text);
                int Sociology = Convert.ToInt32(EntrySociology.Text);
                 total = Arabic + English + Maths + Sociology;
                EntryTotal.Text = total.ToString();


                if (total >= 50)
                {
                    EntrySuccess.Text = "ناجح";
                }

                else
                {
                    EntrySuccess.Text = "راسب";
                }
            }
            catch (Exception)
            {

                return;
            }
           
            
        }


        private async void GetALLData()
        {
            var datas = await ApiService.GetStudents();
            foreach (var data in datas)
            {
                DataCollection.Add(data);
            }
            PickerResult.ItemsSource = DataCollection;
            
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = sender as Picker;
            var selectedCategory = (Student)picker.SelectedItem;
            StudentId = selectedCategory.Id;
            
        }
    }
}