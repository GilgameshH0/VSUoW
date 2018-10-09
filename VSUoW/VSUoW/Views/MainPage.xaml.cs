﻿using VSUoW.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VSUoW.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.News, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.News:
                        MenuPages.Add(id, new NavigationPage(new NewsPage()));
                        break;
                    case (int)MenuItemType.Nav:
                        MenuPages.Add(id, new NavigationPage(new NavigatorPage()));
                        break;
                    case (int)MenuItemType.AbUn:
                        MenuPages.Add(id, new NavigationPage(new AbUnPage()));
                        break;
                    case (int)MenuItemType.Scanner:
                        MenuPages.Add(id, new NavigationPage(new ScannerPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
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