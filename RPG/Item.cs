﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Item
    {
        public string Name { get; set; }
        public Item() { }
        public Item(string name)
        {
            Name = name;
        }
    }

}
