using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                        Info.Text = "Начальник управления внеучебной (воспитательной) работы - Тихонов Антон Викторович  \n Контактная информация: \n Ауд. 321, тел.: (831) 419 - 78 - 13; 8 - 920 - 259 - 02 - 49 \n E - mail: tihonov @vsawt.com";
                    }
                    if (QrResult == "2")
                    {
                        InfoImg.Source = "p2.jpg";
                        Info.Text = "Заместитель декана по внеучебной (воспитательной) работе Екатерина Алексеевна Черепкова\n  Контактная информация: Тел.:  8-904-781-82-70.  ";
                    }
                    if (QrResult == "3")
                    {
                        InfoImg.Source = "p3.jpg";
                        Info.Text = "начальник КБ Гордлеев Сергей \n Контактная информация:\n Тел.: (831) 426-53-33 ";
                    }
                    if (QrResult == "4")
                    {
                        InfoImg.Source = "p4.jpg";
                        Info.Text = "Тьютор - Сахарова Елена Михайловна \n Контактная информация:\n Тел.: (831) 419-78-13  ";
                    }
                    if (QrResult == "5")
                    {
                        InfoImg.Source = "p5.jpg";
                        Info.Text = "Ректор - Кузьмичев Игорь Константинович \n Контактная информация:\n тел. (831) 419 - 47 - 56 \n E - mail: rector @vgavt-nn.ru";
                    }
                    if (QrResult == "6")
                    {
                        InfoImg.Source = "p6.jpg";
                        Info.Text = "проректор по научной работе - Корнев Андрей Борисович \n Контактная информация:\n тел. (831) 419-92-48 ";
                    }
                });
            };
        }
    }
}