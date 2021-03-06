﻿using App3.Models;
using App3.Photo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Cream
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Neutrogena : ContentPage
	{
		public Neutrogena ()
        {
            List<Ingredient> ingredient = new List<Ingredient>();

            ingredient.Add(new Ingredient("1", "Citric Acid", "http://www.softschools.com/formulas/images/citric_acid_formula_1.png"));
            ingredient.Add(new Ingredient("2", "Glycerin", "https://biologydictionary.net/wp-content/uploads/2017/06/Glycerine-Structural-Formula-V1.jpg"));
            ingredient.Add(new Ingredient("3", "Stearic Acid", "https://pubchem.ncbi.nlm.nih.gov/image/imgsrv.fcgi?cid=5281&t=l"));
            ingredient.Add(new Ingredient("4", "Phenoxyethanol", "https://pubchem.ncbi.nlm.nih.gov/image/imgsrv.fcgi?cid=5281&t=l"));
            ingredient.Add(new Ingredient("5", "Isopropyl Palmitate", "https://pubchem.ncbi.nlm.nih.gov/image/imgsrv.fcgi?cid=8907&t=l"));

            InitializeComponent();
            NeutrogenaListView.ItemsSource = ingredient;
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