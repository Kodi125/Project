/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 2 / 2 / 2020
 * Description : Code for CA project (bar till system)
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{

    #region enum
    public enum DrinkType
    {
        Draught,
        Minerals,
        Wine,
        TeasAndCoffees,
        BottledBeer, 
        Liqueurs, 
        Shots,

    }
    #endregion enum

    class Drink
    {
        #region Properties
        public string Name { get; set; }
        public double Cost { get; set; }
        public DrinkType TypeOfDrink { get; set; }
        public DateTime ExpiryDate { get; set; }
        #endregion Properties

        #region Constructors
        public Drink()
        {

        }
        public Drink(string name, double cost, DrinkType type, DateTime bbd)
        {
            Name = name;
            Cost = cost;
            TypeOfDrink = type;
            ExpiryDate = bbd;
        }
        #endregion Constructors
    }
}
