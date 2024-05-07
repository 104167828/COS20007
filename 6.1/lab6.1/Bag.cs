﻿using lab6._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Bag : Item, IHaveInventory
    {
        Inventory _inventory = new Inventory();
        public Bag(string[] idents, string name, string desc) : base(idents, name, desc)
        {

        }
        public GameObject Locate(string id)
        {
            if(this.AreYou(id) == true)
            {
                return this;
            }
            return _inventory.Fetch(id);
        }
        public Inventory Inventory { get { return _inventory; } }
        public string FullDescription { get { return $"In the {this.Name} you can see:\n{_inventory.itemList}"; } }
    }
}
