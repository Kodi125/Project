using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public enum DrinkType
    {
        Draught,
        Minerals,
        Wine,
        TeasAndCoffees,
        BottledBeer
    }
    class Drinks
    {
        #region properties
        public string Name { get; set; }
        public double Cost { get; set; }



        #endregion Properties
    }
}
