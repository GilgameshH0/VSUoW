using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Connectivity;
using HtmlAgilityPack;
namespace VSUoW.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OriginalNewsPage : ContentPage
	{
        public List<NewsListOne> NewsListOne1 { get; set; }
        string s1, subString, subStringImg, s2k;
        int indexOfSubstring, index2OfSubstring, ztsch;

        public OriginalNewsPage()
        {

            InitializeComponent();

            Prr();
        }

        public void Prr()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                try
                {
                    Iner.IsVisible = false;
                    Intr.IsVisible = false;
                    Ins.IsVisible = true;
                    HtmlWeb web = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc = web.Load("http://www.vsuwt.ru/newsite/");
                    s1 = doc.Text;
                    subString = "style17";
                    subStringImg = "src=";
                    indexOfSubstring = s1.IndexOf(subString);
                    index2OfSubstring = s1.IndexOf(subString);
                    s1 = s1.Substring(indexOfSubstring - 500);
                    indexOfSubstring = s1.IndexOf(subString);
                    s1 = s1.Substring(0, indexOfSubstring + 7500);


                    NewsListOne1 = new List<NewsListOne>();
                    AddOneNews();
                    AddOneNews();
                    AddOneNews();
                    AddOneNews();
                    AddOneNews();
                    AddOneNews();
                    AddOneNews();
                    AddOneNews();
                    
                    //AddOneNews();
                    Ins.IsVisible = false;
                    Intr.IsVisible = true;

                    this.BindingContext = this;

                }
                catch
                {
                    Ins.IsVisible = false;
                    Intr.IsVisible = false;
                    Iner.IsVisible = true;

                }
            }

            else
            {
                Ins.IsVisible = false;
                Intr.IsVisible = false;
                Iner.IsVisible = true;
            }

        }

        async void Inb(object sender, EventArgs args)
        {
            Prr();
        }


        public void AddOneNews()
        {
            NewsListOne NewsListOne0 = new NewsListOne();

            indexOfSubstring = s1.IndexOf(subStringImg); //находим урл картинки
            s2k = s1.Substring(indexOfSubstring + 5, 55);

            //uri0 = "http://www.vsuwt.ru" + s2k;
            NewsListOne0.uri = "http://www.vsuwt.ru" + s2k;

            indexOfSubstring = s1.IndexOf(subString);  //ссылка на новость
            NewsListOne0.url = "http://www.vsuwt.ru" + s1.Substring(indexOfSubstring + 15, 24);

            index2OfSubstring = s1.IndexOf("</a><br />");//заголовок
            NewsListOne0.text1 = s1.Substring(indexOfSubstring + 41, index2OfSubstring - indexOfSubstring - 41);
            NewsListOne0.text1 = NewsListOne0.text1.Replace("&quot;", "") + ".";

            indexOfSubstring = s1.IndexOf("div");//текст
            index2OfSubstring = s1.IndexOf("/div");
            NewsListOne0.text2 = s1.Substring(indexOfSubstring + 20, index2OfSubstring - indexOfSubstring - 21);
            NewsListOne0.text2 = NewsListOne0.text2.Replace("&quot;", "");
            NewsListOne0.text2 = NewsListOne0.text2.Replace("&nbsp;&nbsp;", "");
            NewsListOne0.text2 = NewsListOne0.text2.Replace("<br />", "");
            NewsListOne0.text2 = NewsListOne0.text2.Replace("&#40;", "");
            NewsListOne0.text2 = NewsListOne0.text2.Replace("&#41;", "");
            s1 = s1.Substring(index2OfSubstring + 5);

            if ((ztsch % 2) == 0)//цвета через 2
            {
                NewsListOne0.bg = "#E5EAF0";
            }
            else
            {
                NewsListOne0.bg = "White";
            }

            NewsListOne1.Add(NewsListOne0);

            ztsch++;
        }

        public async void Selected1(object sender, ItemTappedEventArgs e)
        {

            NewsListOne n1 = (NewsListOne)e.Item;
            Page1.ii = n1.url;

            await Navigation.PushAsync(new Page1());

        }
    }
}