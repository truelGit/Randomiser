using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Randomiser
{
    public partial class MainPage : ContentPage
    {
        public IList<Phone> Phones { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Phones = new List<Phone>();
            this.BindingContext = this;
        }

        private void NewVariant_Clicked(object sender, EventArgs e)
        {
            //await DisplayAlert("New", "Added", "Ok");
            Application.Current.MainPage = new NavigationPage(new NewVariant(this.Phones, this));
        }
        private async void Start_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, this.Phones.Count);
            var phone = this.Phones[value];
            await DisplayAlert("New", phone.Name, "Ok");
        }        
    }

    public class Phone
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
