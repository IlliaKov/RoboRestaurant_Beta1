using System;
namespace Robo_Restaurant.Properties
{


    public class Ingredients
    {
        private string iname;
        private int quantity;
        private bool tempChange;

        public string Iname
        {
            get { return iname; }
            set { iname = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public bool TempChange
        {
            get { return tempChange; }
            set { tempChange = value; }
        }

        public Ingredients(string iname, int quantity, bool tempChange)
        {
            Iname = iname;
            Quantity = quantity;
            TempChange = tempChange;

            if (Quantity < 1) throw new Exception("You can't cook with current amount of ingredients");
        }
    }
}

