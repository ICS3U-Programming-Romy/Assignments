/*
 * Created by: Romy I. Chu III
 * Created on: 19-03-2019
 * Created for: ICS3U Programming
 * Assignment #5b - Pizza Order
 * This program... that allows the user to order a custom pizza
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Assign5bPizzaOrderRChuIII
{
    public partial class frmPizzaOrder : Form
    {
        //Some variables and constants are marked as public or public static, this is so that they can be referenced from other forms

        //For Pizza Sizes
        double pizzaSizeCost;
        double pizzaAmountCost;
        int pizzaSizeChoice;
        
        //Pizza sizes
        const int NO_PIZZA = 0;
        const int MED_PIZZA = 1;
        const int LRG_PIZZA = 2;
        const int XLRG_PIZZA = 3;

        //For Toppings
        double toppingsCost;

        //For Drinks
        double drinksCost;
        double cokeCost;
        double spriteCost;
        double briskCost;
        double waterCost;

        //Province Taxes
        double province = 1;
        const double ALBERTA = 1.05;
        const double ONTARIO = 1.13;
        const double QUEBEC = 1.14975;
        const double SASKATCHEWAN = 1.11;
        const double NEW_BRUNSWICK = 1.15;
        const double BRITISH_COLUMBIA = 1.12;

        //Coupon Codes (used in the other coupon form)
        public const double FIVE = 0.95;
        public const double SEVEN = 0.93;
        public const double TEN = 0.90;
        public const double TWELVE = 0.88;
        public const double FIFTEEN = 0.85;
        public const double TWENTY_FIVE = 0.75;

        //Totals
        double subTotal;
        public static double total;
        //List<double> costOfMultiOrder = new List<double>();

        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        //These are for the check boxes that enable the order options (Pizza, Toppings and Drinks).
        #region Order Choice
        private void chkPizza_CheckedChanged(object sender, EventArgs e)
        {
            //When the Pizza check box is clicked, it will enable and disable the pizza size options.
            if (grbPizzaOptions.Enabled == false)
            {
                this.grbPizzaOptions.Enabled = true;
                this.chkToppings.Enabled = true;
            }
            else
            { this.grbPizzaOptions.Enabled = false;
                //This if statement prevents the user from buying toppings without a pizza.
                if (chkToppings.Checked)
                {
                    this.chkToppings.Checked = false;
                    this.chkToppings.Enabled = false;
                    this.grbToppings.Enabled = false;
                    nudToppingAmount.Value = 0;
                    
                }
            }   
        }

        private void chkToppings_CheckedChanged(object sender, EventArgs e)
        {
            //This check box will only turn on when the pizza check box is also clicked
            //It will Enable and disable the toppings amount options.
                if (grbToppings.Enabled == false)
                {
                    this.grbToppings.Enabled = true;
                }
                else { this.grbToppings.Enabled = false;
                    nudToppingAmount.Value = 0;}
        }

        private void chkDrinks_CheckedChanged(object sender, EventArgs e)
        {
            //This check box will enable and disable the drinks options.
            if (grbDrinks.Enabled == false)
            {
                this.grbDrinks.Enabled = true;
            }
            else { this.grbDrinks.Enabled = false; }
        }
        #endregion
        

        //In all of these funtions, when the radio button is clicked it will change the pizza cost and size choice to the respective choice
        //It also prevents the user from buying, for example, 5 'No pizzas'.
        //It will also run the UpdateOderLabels function (More information below).
        #region Pizza Cost Updates
        private void radMed_OnClicked(object sender, EventArgs e)
        {
            pizzaSizeCost = 6.99;
            pizzaSizeChoice = MED_PIZZA;
            nudPizzaAmount.Enabled = true;
            UpdateOrderLabels();
        }

        private void radLrg_OnClicked(object sender, EventArgs e)
        {
            pizzaSizeCost = 9.99;
            pizzaSizeChoice = LRG_PIZZA;
            nudPizzaAmount.Enabled = true;
            UpdateOrderLabels();
        }

        private void radXLrg_OnClicked(object sender, EventArgs e)
        {
            pizzaSizeCost = 12.99;
            pizzaSizeChoice = XLRG_PIZZA;
            nudPizzaAmount.Enabled = true;
            UpdateOrderLabels();
        }
        private void radNoPizza_CheckedChanged(object sender, EventArgs e)
        {
            pizzaSizeCost = 0;
            pizzaSizeChoice = NO_PIZZA;

            nudPizzaAmount.Enabled = false;
            nudPizzaAmount.Value = 0;

            UpdateOrderLabels();
        }
        private void nudPizzaAmount_ValueChanged(object sender, EventArgs e)
        {
            UpdateOrderLabels();
        }

        #endregion


        //The cost of the toppings will change in relation to the number of toppings.
        //It will also run the UpdateOderLabels function (More information below).
        #region Toppins Cost Updates
        private void nudToppingAmount_ValueChanged(object sender, EventArgs e)
        {
            if (nudToppingAmount.Value == 0) {
                toppingsCost = 0;
            }
            if (nudToppingAmount.Value == 1) {
                toppingsCost = 0.75;
            }
            if (nudToppingAmount.Value == 2)  {
                toppingsCost = 1.35;
            }
            if (nudToppingAmount.Value == 3) {
                toppingsCost = 2.15;
            }
            if (nudToppingAmount.Value == 4)  {
                toppingsCost = 2.75;
            }
            if (nudToppingAmount.Value == 5) {
                toppingsCost = 3.55;
            }

            UpdateOrderLabels();
        }
        #endregion


        //These check boxes will allow the user to choose which drinks they want
        //It enables/disables the coresponding drink choice.
        #region Drinks Enable Changes
        private void chkDrink1_OnClicked(object sender, EventArgs e)
        {
            if (nudCoke.Enabled == false) {this.nudCoke.Enabled = true;}
            else {this.nudCoke.Enabled = false;}
        }

        private void chkDrink2_OnClicked(object sender, EventArgs e)
        {
            if (nudSprite.Enabled == false) {this.nudSprite.Enabled = true;}
            else {this.nudSprite.Enabled = false;}
        }

        private void chkDrink3_OnClicked(object sender, EventArgs e)
        {
            if (nudBrisk.Enabled == false){this.nudBrisk.Enabled = true;}
            else{this.nudBrisk.Enabled = false;}
        }

        private void chkDrink4_OnClicked(object sender, EventArgs e)
        {
            if (nudWater.Enabled == false) {this.nudWater.Enabled = true;}
            else {this.nudWater.Enabled = false;}
        }
        #endregion


        //THe check boxes will update the price of the drinks that the user chose, It also totals up all of the selected drink costs.
        //It will also run the UpdateOderLabels function (More information below).
        #region Drinks Cost Changes
        private void nudCoke_ValueChanged(object sender, EventArgs e)
        {
            cokeCost = Convert.ToDouble(nudCoke.Value) * 1.50;
            drinksCost = cokeCost + spriteCost + briskCost + waterCost ;
            UpdateOrderLabels();
        }

        private void nudSprite_ValueChanged(object sender, EventArgs e)
        {
            spriteCost = Convert.ToDouble(nudSprite.Value) * 1.50;
            drinksCost = cokeCost + spriteCost + briskCost + waterCost;
            UpdateOrderLabels();
        }

        private void nudBrisk_ValueChanged(object sender, EventArgs e)
        {
            briskCost = Convert.ToDouble(nudBrisk.Value) * 1.50;
            drinksCost = cokeCost + spriteCost + briskCost + waterCost;
            UpdateOrderLabels();
        }

        private void nudWater_ValueChanged(object sender, EventArgs e)
        {
            waterCost = Convert.ToDouble(nudWater.Value) * 1.00;
            drinksCost = cokeCost + spriteCost + briskCost + waterCost;
            UpdateOrderLabels();
        }
        #endregion


        //When these radio buttons are pressed, the selected province tax will be selected (changes the HST on the order list too).
        //It will also run the UpdateOderLabels function (More information below).
        #region Provinces
        private void radAlberta_CheckedChanged(object sender, EventArgs e)
        {
            province = ALBERTA;
            lblHST.Text = "HST : 5%";
            UpdateOrderLabels();
        }

        private void radOntario_CheckedChanged(object sender, EventArgs e)
        {
            province = ONTARIO;
            lblHST.Text = "HST : 13%";
            UpdateOrderLabels();
        }

        private void radQuébec_CheckedChanged(object sender, EventArgs e)
        {
            province = QUEBEC;
            lblHST.Text = "HST : 14.975%";
            UpdateOrderLabels();
        }

        private void radSaskatchewan_CheckedChanged(object sender, EventArgs e)
        {
            province = SASKATCHEWAN;
            lblHST.Text = "HST : 11%";
            UpdateOrderLabels();
        }

        private void radNewBrunswick_CheckedChanged(object sender, EventArgs e)
        {
            province = NEW_BRUNSWICK;
            lblHST.Text = "HST : 15%";
            UpdateOrderLabels();
        }

        private void radBritishColumbia_CheckedChanged(object sender, EventArgs e)
        {
            province = BRITISH_COLUMBIA;
            lblHST.Text = "HST : 12%";
            UpdateOrderLabels();
        }
        #endregion


        //This function is used to update the "Your Order" tab as the user is making their selection.
        public void UpdateOrderLabels ()
        {
            //This updates the label for the Pizza Size chosen, amount of pizzas, and the cost of the pizza(s).
            #region pizza size choice labels
            string sizeName = "";
            if (pizzaSizeChoice == NO_PIZZA){
                sizeName = "No Pizza";
            }

            if (pizzaSizeChoice == MED_PIZZA){
                sizeName = "Medium";
            }

            if (pizzaSizeChoice == LRG_PIZZA){
                sizeName = "Large";
            }

            if (pizzaSizeChoice == XLRG_PIZZA){
                sizeName = "Extra Large";
            }

            pizzaAmountCost = pizzaSizeCost * (double)nudPizzaAmount.Value;

            this.lblSizeChoice.Text = "Pizza Size : " + sizeName + "  (" + String.Format("${0:0.00}", pizzaSizeCost) + ")";
            this.lblPizzaAmountChoice.Text = "# of Pizzas: " + "  (" + String.Format("${0:0.00}", pizzaAmountCost) + ")";
            #endregion


            //Updates the label for the amount of toppings
            this.lblNumToppings.Text = "# of Toppings: " + nudToppingAmount.Value + "  (" + String.Format("${0:0.00}", toppingsCost) + ")";


            //This updates the label for all of the drinks
            this.lblNumDrinks.Text = "# of Drinks:" + "  (" + String.Format("${0:0.00}", drinksCost) + ")"
                + "\n     Coke: " +   nudCoke.Value + "  (" + String.Format("${0:0.00}", cokeCost) + ")" 
                + "\n     Sprite: " + nudSprite.Value + "  (" + String.Format("${0:0.00}", spriteCost) + ")" 
                + "\n     Brisk: " + nudBrisk.Value  + "  (" + String.Format("${0:0.00}", briskCost) + ")" 
                + "\n     Water: " + nudWater.Value + "  (" + String.Format("${0:0.00}", waterCost) + ")";

            //This calculates the subtotal
            subTotal = pizzaAmountCost + toppingsCost + drinksCost;
            lblsubTotal.Text = "Subtotal : " + String.Format("${0:0.00}", subTotal);

            //This calcualtes the total with the given province.
            total = subTotal * province;
            this.lblTotal.Text = String.Format("${0:0.00}", total);
        }


        //THis completely restarts the form. So that the user can redo their order.
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        //This will 'process' the order
        private void btnOrder_Click(object sender, EventArgs e)
        {
            var CouponForm = new frmCoupons();

            //Prevents the user from proceeding to checkout without choosing a province or not ordering anything.
            if (total == 0)
            {
                MessageBox.Show("You Must Choose Something to Order!!");
            }
            else
            {
                if (province == 1)
                {
                    MessageBox.Show("You Must Choose a Province!!");
                }
                else
                {
                    CouponForm.Show();
                    this.Enabled = false;
                    
                }
            }
        }
    }
}
