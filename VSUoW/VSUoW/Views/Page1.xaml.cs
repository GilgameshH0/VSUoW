using HtmlAgilityPack;
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
	public partial class Page1 : ContentPage
	{
        public static string ii;
        string s1, s2k;
        int indexOfSubstring, index2OfSubstring;
        public Page1 ()
		{
			InitializeComponent ();

            Prr();
        }

        async void Inb(object sender, EventArgs args)
        {
            Prr();

        }

        public void Prr()
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = web.Load(ii);
                s1 = doc.Text;

                indexOfSubstring = s1.IndexOf("header");

                s2k = s1.Substring(0, indexOfSubstring + 9);//скопировали всю полезную верхушку
                s1 = s1.Substring(indexOfSubstring + 9);//стерли ее)

                ///subString = "FFFFFF";
                indexOfSubstring = s1.IndexOf("FFFFFF");//находим то что нужно
                s1 = s1.Substring(indexOfSubstring + 8);//стираем все до него
                                                        //subString = "FOOT";
                indexOfSubstring = s1.IndexOf("FOOT");
                s2k += s1.Substring(0, indexOfSubstring - 330);//копируем нужное
                s2k += "</div></div></div></body>";

                indexOfSubstring = 0;                   //удаление скриптов
                while (indexOfSubstring > -1)
                {

                    indexOfSubstring = s2k.IndexOf("<script");
                    index2OfSubstring = s2k.IndexOf("</script");

                    if (indexOfSubstring > -1) s2k = s2k.Remove(indexOfSubstring, index2OfSubstring - indexOfSubstring + 9);
                }

                indexOfSubstring = s2k.IndexOf("fvb") - 9;
                index2OfSubstring = s2k.IndexOf("</head");

                s2k = s2k.Remove(indexOfSubstring, index2OfSubstring - indexOfSubstring);




                indexOfSubstring = s2k.IndexOf("<br><!--WORK");//костыли для удаления переноса строк внизу
                s2k = s2k.Remove(indexOfSubstring - 204, 200);


                indexOfSubstring = s2k.IndexOf("<table");//костыли для белого цвета страници
                s2k = s2k.Insert(indexOfSubstring + 6, " bgcolor=\"#FFFFFF\"");

                //l1.Text = s2k;
                var htmlSource = new HtmlWebViewSource();
                htmlSource.Html = s2k;
                htmlSource.BaseUrl = "http://www.vsuwt.ru";
                webb.Source = htmlSource;

            }
            catch
            {
                Iner1.IsVisible = true;
                Iner2.IsVisible = true;
                webb.IsVisible = false;

            }

        }


    }
}