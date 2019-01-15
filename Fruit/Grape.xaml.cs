using App3.Models;
using App3.Photo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Fruit
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Grape : ContentPage
	{
		public Grape ()
		{ List<Ingredient> ingredient = new List<Ingredient>();

            ingredient.Add(new Ingredient("1", "Citric Acid", "http://www.softschools.com/formulas/images/citric_acid_formula_1.png"));
          
            InitializeComponent();
            Title = "Structures";
            GrapeListView.ItemsSource = ingredient;
		}
        private async void ItemsListView_OnItemTapped(object sender, EventArgs e)
        {

            var img_alt = (Image)sender;

            if (img_alt != null)
            {
                string img_source = img_alt.Source.ToString();
                string img_url = img_source.Substring(5, img_source.Length - 5);
                ModelForImage img_model = new ModelForImage { ImageSource = img_url };
                await Navigation.PushAsync(new Molecule(img_model));

            }
        }
    }
}