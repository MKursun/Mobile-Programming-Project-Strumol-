
using App3.Models;
using App3.Photo;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lemon : ContentPage
	{
		public Lemon ()
		{
            List<Ingredient> ingredient = new List<Ingredient>();

            ingredient.Add(new Ingredient("1", "Citric Acid", "http://www.softschools.com/formulas/images/citric_acid_formula_1.png"));
            ingredient.Add(new Ingredient("2", "Arginine", "https://pubchem.ncbi.nlm.nih.gov/image/imgsrv.fcgi?cid=6322&t=l"));
            ingredient.Add(new Ingredient("3", "Lineolic Acid", "https://pubchem.ncbi.nlm.nih.gov/image/imgsrv.fcgi?cid=5280450&t=l"));

            InitializeComponent();
            Title = "Structures";
        
            LemonListView.ItemsSource = ingredient;
            
		}
        private async void ItemsListView_OnItemTapped(object sender, EventArgs e)
        {

            var img_alt = (Image)sender;

            if (img_alt != null)
            {
                string img_source = img_alt.Source.ToString();
                string img_url = img_source.Substring(5, img_source.Length - 5);
                ModelForImage img_model = new ModelForImage {ImageSource=img_url };
                await Navigation.PushAsync(new Molecule(img_model));

            }
        }


    }
}