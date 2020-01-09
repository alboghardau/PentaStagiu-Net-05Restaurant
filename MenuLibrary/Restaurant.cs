using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
    class Restaurant : IRestaurant
    {
        List<MenuItem> Items;
        

        public Restaurant()
        {
            this.Items = new List<MenuItem>();
        }
        public void AddItem(MenuItem item)
        {
            this.Items.Add(item);
        }

        public void EditItem(MenuItem oldItem, MenuItem newItem)
        {

        }

        public void RemoveItem(MenuItem item)
        {

        }
    }
}
