using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
    public class Restaurant : IRestaurant
    {
        List<MenuItem> Items;
        
        public Restaurant()
        {
                this.Items = new List<MenuItem>();       
        }


    //methods
    public void AddItem(MenuItem item)
        {
            this.Items.Add(item);
        }

        public void EditItem(MenuItem oldItem, MenuItem newItem)
        {
            this.RemoveItem(oldItem.Id);
            this.AddItem(newItem);
        }

        public List<MenuItem> GetAllItems()
        {
            this.Items.Sort();
            return this.Items;
        }

        public MenuItem GetItemById(int id)
        {
            return this.Items.Find(item => item.Id.Equals(id));
        }

        public int GetTotalItems()
        {
            return this.Items.Count;
        }

        public void RemoveItem(int id)
        {
            MenuItem item = this.GetItemById(id);
            this.Items.Remove(item);
        }
    }
}
