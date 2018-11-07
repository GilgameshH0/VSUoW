using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HtmlAgilityPack;
namespace VSUoW.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OriginalNewsPage : ContentPage
	{
        string url1 = "http://www.vsuwt.ru";
        string url2 = "http://www.vsuwt.ru";
        string url3 = "http://www.vsuwt.ru";
        string url4 = "http://www.vsuwt.ru";
        string url5 = "http://www.vsuwt.ru";
        string url6 = "http://www.vsuwt.ru";

        public OriginalNewsPage ()
		{

			InitializeComponent ();

        //    HtmlWeb web = new HtmlWeb();
        //    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        //    doc = web.Load("http://www.vsuwt.ru/newsite/");
        //    string s1 = doc.Text;
        //    string subString = "style17";
        //    string subStringImg = "src=";
        //    int indexOfSubstring = s1.IndexOf(subString);
        //    int index2OfSubstring = s1.IndexOf(subString);
        //    s1 = s1.Substring(indexOfSubstring - 500);
        //    indexOfSubstring = s1.IndexOf(subString);
        //    s1 = s1.Substring(0, indexOfSubstring + 5000);

        //    ///
        //    indexOfSubstring = s1.IndexOf(subStringImg); //находим урл картинки
        //    string s2k = s1.Substring(indexOfSubstring + 5, 55);

        //    string s3k = "http://www.vsuwt.ru" + s2k;


        //    uri1.Source = new Uri(s3k);
        //    uri1.HeightRequest = 80;
        //    uri1.WidthRequest = 80;
        //    uri1.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    uri1.VerticalOptions = LayoutOptions.CenterAndExpand;


        //    indexOfSubstring = s1.IndexOf(subString);  //ссылка на новость
        //    url1 = url1 + s1.Substring(indexOfSubstring + 15, 24);


        //    index2OfSubstring = s1.IndexOf("</a><br />");//заголовок
        //    label1.Text = s1.Substring(indexOfSubstring + 41, index2OfSubstring - indexOfSubstring - 41);
        //    label1.Text = label1.Text.Replace("&quot;", "") + ".";

        //    indexOfSubstring = s1.IndexOf("div");//текст
        //    index2OfSubstring = s1.IndexOf("/div");
        //    label2.Text = s1.Substring(indexOfSubstring + 20, index2OfSubstring - indexOfSubstring - 21);
        //    label2.Text = label2.Text.Replace("&quot;", "");
        //    label2.Text = label2.Text.Replace("<br />", "");
        //    if (label2.Text.Length > 145)
        //    {
        //        label2.Text = label2.Text.Substring(0, 125) + "...";
        //    }
        //    s1 = s1.Substring(index2OfSubstring + 5);








        //    ///
        //    indexOfSubstring = s1.IndexOf(subStringImg); //находим урл картинки
        //    s2k = s1.Substring(indexOfSubstring + 5, 55);

        //    s3k = "http://www.vsuwt.ru" + s2k;

        //    //uri11 = new Uri(s3k);
        //    uri2.Source = new Uri(s3k);
        //    uri2.HeightRequest = 80;
        //    uri2.WidthRequest = 80;
        //    uri2.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    uri2.VerticalOptions = LayoutOptions.CenterAndExpand;

        //    indexOfSubstring = s1.IndexOf(subString);  //ссылка на новость
        //    url2 = url2 + s1.Substring(indexOfSubstring + 15, 24);


        //    index2OfSubstring = s1.IndexOf("</a><br />");//заголовок
        //    label3.Text = s1.Substring(indexOfSubstring + 41, index2OfSubstring - indexOfSubstring - 41);
        //    label3.Text = label3.Text.Replace("&quot;", "") + ".";

        //    indexOfSubstring = s1.IndexOf("div");//текст
        //    index2OfSubstring = s1.IndexOf("/div");
        //    label4.Text = s1.Substring(indexOfSubstring + 20, index2OfSubstring - indexOfSubstring - 21);
        //    label4.Text = label4.Text.Replace("&quot;", "");
        //    label4.Text = label4.Text.Replace("<br />", "");
        //    if (label4.Text.Length > 145)
        //    {
        //        label4.Text = label4.Text.Substring(0, 125) + "...";
        //    }

        //    s1 = s1.Substring(index2OfSubstring + 5);
        }
	}
}