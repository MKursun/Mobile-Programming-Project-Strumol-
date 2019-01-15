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
	public partial class Peach : ContentPage
	{
		public Peach ()
		{
            List<Ingredient> ing = new List<Ingredient>();
            ing.Add(new Ingredient("1", "Citric Acid", "http://www.softschools.com/formulas/images/citric_acid_formula_1.png"));
            ing.Add(new Ingredient("2", "Valine", "https://pubchem.ncbi.nlm.nih.gov/image/imgsrv.fcgi?cid=6287&t=l"));
            ing.Add(new Ingredient("3", "Benzaldhyde", "https://pubchem.ncbi.nlm.nih.gov/image/imgsrv.fcgi?cid=240&t=l"));

            InitializeComponent();
            PeachListView.ItemsSource = ing;
            Title = "Structures";
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