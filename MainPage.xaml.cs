
using App3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "STRUMOL";
        }
        

       async  public void OnTapGestureRecognizerTapped(object sender ,EventArgs e)
        {               
            await Navigation.PushAsync(new FruitPage());
        }
        async public void PerfumeTabbed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfumes());
        }
        async public void CreamTabbed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Creams());
        }
        async public void MakeUpTabbed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MakeUps());
        }

    }
}
