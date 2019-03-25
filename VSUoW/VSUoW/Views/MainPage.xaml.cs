using VSUoW.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Reflection;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace VSUoW.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Split;

            MenuPages.Add((int)MenuItemType.Start, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Start:
                        MenuPages.Add(id, new NavigationPage(new StartPage()));
                        break;
                    case (int)MenuItemType.News:
                        MenuPages.Add(id, new NavigationPage(new OriginalNewsPage()));
                        break;

                    case (int)MenuItemType.Calendar:
                        MenuPages.Add(id, new NavigationPage(new Calendar()));
                        break;

                    case (int)MenuItemType.Nav:
                        MenuPages.Add(id, new NavigationPage(new EnterNav1()));
                        break;
                    
                    case (int)MenuItemType.shedule:
                        MenuPages.Add(id, new NavigationPage(new schedule()));
                        break;

                    case (int)MenuItemType.biblio:
                        MenuPages.Add(id, new NavigationPage(new Biblio()));
                        break;

                    case (int)MenuItemType.Scanner:
                        MenuPages.Add(id, new NavigationPage(new ScannerPage()));
                        break;

                    
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);
                
                IsPresented = false;
            }
        }
    }
}