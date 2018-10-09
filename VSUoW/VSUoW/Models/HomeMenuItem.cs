﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VSUoW.Models
{
    public enum MenuItemType
    {
        News,
        AbUn,
        Nav,
        Scanner,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}