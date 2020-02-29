using System;
using System.Collections.Generic;

namespace Robo_Restaurant.Properties
{
    public class Ordering
    {

        Menu menuDish = new Menu();

        IngredientsBasement Base = new IngredientsBasement();


        public Ordering()
        {
            menuDish.AddingDish();
        }

        public void MakeOrder(Dish.dishName DM)
        {
            foreach (var dish in menuDish.dishes)
            {
                if (DM == dish.dName)
                {
                    foreach (var ing in dish.Ingredients)
                    {
                        foreach (var ing1 in Base.IngList)
                        {
                            if (ing1.Iname == ing.Iname)
                            {
                                if (ing1.Quantity > 0) ing1.Quantity--;

                                else throw new Exception("Excuse us, but there are not enough ingredients in the kitchen to cook your dish");
                            }
                        }
                    }
                }
            }
        }
    }
}

