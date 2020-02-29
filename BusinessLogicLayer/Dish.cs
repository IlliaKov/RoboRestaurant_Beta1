using System;
using System.Collections.Generic;

namespace Robo_Restaurant.Properties
{
    public class Dish
    {
        private int weight;
        private int timeofprep;
        private List<Ingredients> ingredients = new List<Ingredients>();
        private int price;
        public dishName dName;

        public enum dishName
        {
            Borsch,
            Green_Borsch,
            Vegetable_Soup,
            Strawberry_Jelly,
            Banana_Juice
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int TimeOfPrep
        {
            get { return timeofprep; }
            set { timeofprep = value; }
        }
        public List<Ingredients> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Dish(dishName dname, int weight, int timeofprep, List<Ingredients> ingred, int price)
        {

            dName = dname;
            Weight = weight;
            TimeOfPrep = timeofprep;
            Ingredients = ingred;
            Price = price;


        }

    }
}

