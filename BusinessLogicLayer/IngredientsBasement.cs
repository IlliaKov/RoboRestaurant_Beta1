using System;
using System.Collections.Generic;

namespace Robo_Restaurant.Properties
{
    public class IngredientsBasement
    {
        public List<Ingredients> IngList = new List<Ingredients>();


        public IngredientsBasement()
        {
            IngList.Add(new Ingredients("Water", 1, false));
            IngList.Add(new Ingredients("Beef", 1, true));
            IngList.Add(new Ingredients("Cabbage", 5, true));
            IngList.Add(new Ingredients("Beetroot", 5, true));
            IngList.Add(new Ingredients("Potato", 10, true));
            IngList.Add(new Ingredients("Carrot", 10, false));
            IngList.Add(new Ingredients("Sorrel", 5, true));
            IngList.Add(new Ingredients("Strawberry", 5, false));
            IngList.Add(new Ingredients("Jelly", 5, false));
            IngList.Add(new Ingredients("Banana_juice", 5, false));
        }
    }
}

