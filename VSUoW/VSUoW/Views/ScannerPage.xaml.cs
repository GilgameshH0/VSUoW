using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;
namespace VSUoW.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScannerPage : ContentPage
	{
		public ScannerPage ()
		{
			InitializeComponent ();
		}
        private async void OpenScanWindow(object sender, EventArgs e)
        {
            //  NavigationPage.SetHasNavigationBar(this, true);
            var scan = new ZXingScannerPage();
            await Navigation.PushAsync(scan);
            scan.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    string QrResult = result.Text;
                    if (QrResult == "1")
                    {
                        InfoImg.Source = "p1.jpg";
                        Info.Text = "Антон Викторович Тихонов";
                    }
                    if (QrResult == "2")
                    {
                        InfoImg.Source = "p2.jpg";
                        Info.Text = "Екатерина Алексеевна Черепкова";
                    }
                    if (QrResult == "3")
                    {
                        InfoImg.Source = "p3.jpg";
                        Info.Text = "Сергей Гордлеев";
                    }
                    if (QrResult == "4")
                    {
                        InfoImg.Source = "p4.jpg";
                        Info.Text = "Михаил Иванов";
                    }
                    if (QrResult == "5")
                    {
                        InfoImg.Source = "p5.jpg";
                        Info.Text = "Кузьмичев Игорь Константинович";
                    }
                    if (QrResult == "6")
                    {
                        InfoImg.Source = "p6.jpg";
                        Info.Text = "Корнев Андрей Борисович";
                    }
                });
            };
        }
    }
}