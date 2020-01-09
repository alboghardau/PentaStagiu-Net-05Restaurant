using System;

namespace MenuLibrary
{
    public class MenuItem
    {
        private static int counter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem()
        {
            this.Id = counter++;
        }
    }
}
