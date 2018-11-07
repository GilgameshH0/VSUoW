using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VSUoW.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EnterNav1 : ContentPage
	{
		public EnterNav1 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
          //  Navigation.PushModalAsync(ScannerPage);
        }
    }
}