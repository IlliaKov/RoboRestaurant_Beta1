using System;
using System.Collections.Generic;

namespace Robo_Restaurant.Properties
{
    public class Menu// name it menu class
    {
        public List<Dish> dishes = new List<Dish>();
        public List<Ingredients> ingredients = new List<Ingredients>();
        public IngredientsBasement Basement = new IngredientsBasement();
        public List<Menu> menuD = new List<Menu>();


        public void AddingDish()
        {
            dishes.Add(new Dish(Dish.dishName.Borsch, 300, 15, new List<Ingredients>
            {
                Basement.IngList[0],
                Basement.IngList[1],
                Basement.IngList[2],
                Basement.IngList[3],
                Basement.IngList[4],
                Basement.IngList[5]

            }, 50));
            dishes.Add(new Dish(Dish.dishName.Green_Borsch, 300, 10, new List<Ingredients>
            {
                Basement.IngList[0],
                Basement.IngList[1],
                Basement.IngList[2],
                Basement.IngList[4],
                Basement.IngList[5],
                Basement.IngList[6]
            }, 60));
            dishes.Add(new Dish(Dish.dishName.Vegetable_Soup, 250, 14, new List<Ingredients>
            {
                Basement.IngList[0],
                Basement.IngList[2],
                Basement.IngList[4],
                Basement.IngList[5],

            }, 58));
            dishes.Add(new Dish(Dish.dishName.Strawberry_Jelly, 300, 15, new List<Ingredients>
            {
                Basement.IngList[7],
                Basement.IngList[8]
            }, 50));
            dishes.Add(new Dish(Dish.dishName.Banana_Juice, 300, 15, new List<Ingredients> { Basement.IngList[9] }, 50));
        }
        public void AddSpec(Dish d)
        {
            dishes.Add(d);
        }

    }
}

