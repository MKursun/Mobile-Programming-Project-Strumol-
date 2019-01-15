using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.MarkupExtensions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageSourceExtension : IMarkupExtension
	{
		public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Source == null ? null : ImageSource.FromResource(Source);
        }
    }
}