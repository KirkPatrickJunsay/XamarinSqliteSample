using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleSQLite
{
    public partial class MainPage : ContentPage
    {
        private Person SelectedItem;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGetAll_Clicked(object sender, EventArgs e)
        {
            lstView.ItemsSource = App.PersonRepo.GetAllPerson();
            
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            App.PersonRepo.InsertPerson(new Person()
            {
                Name = entryName.Text
            });
        }

        private void lstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            SelectedItem = e.SelectedItem as Person;
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            App.PersonRepo.DeletePerson(SelectedItem);
        }
    }
}
