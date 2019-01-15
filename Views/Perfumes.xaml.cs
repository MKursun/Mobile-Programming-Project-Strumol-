using App3.Perfume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Perfumes : ContentPage
	{
		public Perfumes ()
		{
			InitializeComponent ();
            Title = "Parfumes";
		}
        async public void Tabbed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfume1());
        }
        async public void Tabbed2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfume2());
        }
        async public void Tabbed3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfume3());
        }
        async public void Tabbed4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfume4());
        }
        async public void Tabbed5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfume5());
        }
        async public void Tabbed6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfume6());
        }
        
    }
}