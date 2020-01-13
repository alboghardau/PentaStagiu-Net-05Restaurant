using System;

namespace MenuLibrary
{
    public class MenuItem : IComparable<MenuItem>
    {
        //id setter to avoid crash on serialization
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //default constructor with incremental Id
        public MenuItem()
        {
            this.Id = counter++;
        }

        //sort items by ID
        public int CompareTo(MenuItem other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
