using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
        public class VegBurger : Burger
    {
        public bool HasOnion { get; set; }

        public override string ToString()
        {
            return "ID: " + this.Id + " " +
                    "NAME: " + this.Name + " " +
                    "PRICE: " + this.Price + " " +
                    "CALORIES: " + this.Calories + " " +
                    "HAS ONION:" + this.HasOnion
                ;
        }
    }
}
