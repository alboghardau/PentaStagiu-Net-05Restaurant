using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
    interface IRestaurant
    {
        void AddItem(MenuItem item);
        void RemoveItem(MenuItem item);
        void EditItem(MenuItem oldItem, MenuItem newItem);
        MenuItem GetItemById(int id);
        int GetTotalItems();
        List<MenuItem> GetAllItems();
    }
}
