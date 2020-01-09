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

        public List<MenuItem> GetAllItems()
        {
            return this.Items;
        }

        public MenuItem GetItemById(int id)
        {
            return this.Items.Find( item => item.Id.Equals(id));
        }

        public int GetTotalItems()
        {
            return this.Items.Count;
        }

        public void RemoveItem(MenuItem item)
        {
            this.Items.Remove(item);
        }
    }
}
