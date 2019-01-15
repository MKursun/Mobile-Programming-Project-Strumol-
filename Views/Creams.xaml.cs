using App3.Cream;
using App3.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Creams : ContentPage
	{
		public Creams ()
		{
			InitializeComponent ();
		}
        async public void Tabbed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Neutrogena());
        }
        async public void Tabbed2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vichy());
        }
        async public void Tabbed3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BodyShop());
        }
        async public void Tabbed4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YvesRocher());
        }
        async public void Tabbed5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MadameCoco());
        }
        async public void Tabbed6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArkoNem());
        }



    }
}