using VSUoW.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VSUoW.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.News, Title="Новости" },
                new HomeMenuItem {Id = MenuItemType.Nav, Title="Навигатор" },
                new HomeMenuItem {Id = MenuItemType.AbUn, Title="Об Университете" },
                new HomeMenuItem {Id =MenuItemType.Scanner, Title="Сканнер" },
                new HomeMenuItem {Id = MenuItemType.About, Title="О приложении" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}