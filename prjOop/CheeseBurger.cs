using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOop
{
     public class CheeseBurger: Burger
    {
        public String Cheese = "Blue Cheese";

        public String getCheese()
        {
            return Cheese;
        }
        public String AddChedder() 
        {
            this.Cheese = "Chadder";
            return this.Cheese;
        }
    }


}
