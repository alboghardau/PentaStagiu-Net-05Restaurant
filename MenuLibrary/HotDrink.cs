using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
        public class HotDrink : Drink
    {
        public bool HasCaffeine { get; set; }
                
        public override string ToString()
        {
            return "ID: " + this.Id + " " +
                    "NAME: " + this.Name + " " +
                    "PRICE: " + this.Price + " " +
                    "VOLUME: " + this.Volume+ "ml "+
                    "HAS CAFFEINE: "+this.HasCaffeine;
                ;
        }
    }
}
