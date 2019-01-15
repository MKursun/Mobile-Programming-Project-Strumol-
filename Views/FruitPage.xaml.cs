using App3.Fruit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FruitPage : ContentPage
	{
		public FruitPage ()
		{
			InitializeComponent ();
            Title = "Fruits";
		}
        async public void Tabbed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lemon());
        }
        async public void Tabbed2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Apple());
        }
        async public void Tabbed3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Orange());
        }
        async public void Tabbed4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Peach());
        }
        async public void Tabbed5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grape());
        }
        async public void Tabbed6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Strawberry());
        }
        async public void Tabbed7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cherry());
        }
    }
}