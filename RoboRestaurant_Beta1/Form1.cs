using Robo_Restaurant.Properties;//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RoboRestaurant_Beta1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ordering order = new Ordering();
            SpecTimeOrder specOrder = new SpecTimeOrder();
            
            if (comboBox1.Text == "Borsch")
            {
                try
                {
                    specOrder.SpecTime();
                    order.MakeOrder(Dish.dishName.Borsch);
                    MessageBox.Show("Your dish is cooking!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("That's it: "+ ex);
                }
            }
            if (comboBox1.Text == "Green_Borsch")
            {
                try
                {
                    specOrder.SpecTime();
                    order.MakeOrder(Dish.dishName.Green_Borsch);
                    MessageBox.Show("Your dish is cooking!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("That's it: " + ex);
                }
            }
            if (comboBox1.Text == "Vegetable_Soup")
            {
                try
                {
                    specOrder.SpecTime();
                    order.MakeOrder(Dish.dishName.Vegetable_Soup);
                    MessageBox.Show("Your dish is cooking!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("That's it: " + ex);
                }
            }
            if (comboBox1.Text == "Strawberry_Jelly")
            {
                try
                {
                    specOrder.SpecTime();
                    order.MakeOrder(Dish.dishName.Strawberry_Jelly);
                    MessageBox.Show("Your dish is cooking!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("That's it: " + ex);
                }
            }
            if (comboBox1.Text == "Banana_Juice")
            {
                try
                {
                    specOrder.SpecTime();
                    order.MakeOrder(Dish.dishName.Banana_Juice);
                    MessageBox.Show("Your dish is cooking!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("That's it: " + ex);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
