﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VSUoW.Models
{
    public enum MenuItemType
    {
        Start,
        News,      
        shedule,
        biblio,
        Nav,
        Scanner,
        Calendar
        
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public static implicit operator HomeMenuItem(Color V)
        {
            
            throw new NotImplementedException();
        }

    }

}
