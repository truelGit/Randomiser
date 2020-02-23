using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Randomiser
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewVariant : ContentPage
	{
        IList<Phone> phones;
        MainPage mainPage;

        public NewVariant (IList<Phone> phones, MainPage mainPage)
		{
			InitializeComponent ();
            this.phones = phones;
            this.mainPage = mainPage;
		}

        private void VariantAdded_Clicked(object sender, EventArgs e)
        {
            var newvariant = variant.Text;
            this.phones.Add(new Phone() { Name = newvariant });
            Application.Current.MainPage = new NavigationPage(mainPage);
        }
    }
}