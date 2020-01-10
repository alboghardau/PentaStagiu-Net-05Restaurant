using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MenuLibrary
{
    public class ChickenBurger : Burger
    {
        public bool HasPickle { get; set; }

        public override string ToString()
        {
            return  "ID: "+this.Id+" "+
                    "NAME: "+this.Name+" "+
                    "PRICE: "+this.Price+" "+
                    "CALORIES: "+this.Calories+" "+
                    "HAS PICKLE:" + this.HasPickle
                ;
        }
    }
}
