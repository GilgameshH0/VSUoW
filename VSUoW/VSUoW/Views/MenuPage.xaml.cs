using VSUoW.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
                new HomeMenuItem {Id = MenuItemType.Start, Title="Начальная страница",  },
                new HomeMenuItem {Id = MenuItemType.News, Title="Новости",  },
                new HomeMenuItem {Id = MenuItemType.Calendar, Title="Календарь событий",  },
                new HomeMenuItem {Id = MenuItemType.shedule, Title="Расписание",  },

                new HomeMenuItem {Id = MenuItemType.biblio, Title="Библиотека",  },

                new HomeMenuItem {Id = MenuItemType.Nav, Title="Навигатор" },
               
                new HomeMenuItem {Id =MenuItemType.Scanner, Title="Сканнер" },

                
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