using System;

namespace MenuLibrary
{
    public class MenuItem
    {
        private static int counter = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //default constructor with incremental Id
        public MenuItem()
        {
            this.Id = counter++;
        }

        //contructor overloading for Id setter on inistantiate
        public MenuItem(int id)
        {
            this.Id = id;
        }
    }
}
