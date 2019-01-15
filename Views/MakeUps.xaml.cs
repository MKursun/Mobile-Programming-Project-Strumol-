using App3.MakeUp;
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
	public partial class MakeUps : ContentPage
	{
		public MakeUps ()
		{
			InitializeComponent ();
            Title = "Make Up";
		}
        async public void Tabbed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MacStraightFire());
        }
        async public void Tabbed2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GRLashVolume());
         }
        async public void Tabbed3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FarmasiFar());
         }
        async public void Tabbed4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HuncalifeAllık());
        }
        async public void Tabbed5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NarsPureMatte());
        }
        async public void Tabbed6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlormarGozKalemi());
        }

    }
}