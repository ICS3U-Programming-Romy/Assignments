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
    public partial class frmCoupons : Form
    {
        //The variable for the totals (before and after the coupon).
        double totalCurent = frmPizzaOrder.total;
        public static double postCoupon = frmPizzaOrder.total;

        public frmCoupons()
        {
            InitializeComponent();
        }

        //When the form loads, it will display the user's current total.
        private void frmCoupons_Load(object sender, EventArgs e)
        {
            lblCurrentTotal.Text = "Your Total Is : " + String.Format("${0:0.00}", totalCurent);
        }

        //Clears the text field if the button is pressed
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCoupon.Text = ""; 
        }

        //Checks if the coupon code that the user used id vaild. If it is valid, a discount will be applied. If not, The user will be informed
        private void btnAddCoupon_Click(object sender, EventArgs e)
        {

            if (txtCoupon.Text == null)
            {
                MessageBox.Show("You have to put in a vaild code!!");
            }
            else if (txtCoupon.Text == "five")
            {
                postCoupon = totalCurent * frmPizzaOrder.FIVE;
                lblTotalAfterCoupon.Text = "After the coupon : " + String.Format("${0:0.00}", postCoupon);
                btnAddCoupon.Enabled = false;
            }
            else if (txtCoupon.Text == "seven")
            {
                postCoupon = totalCurent * frmPizzaOrder.SEVEN;
                lblTotalAfterCoupon.Text = "After the coupon : " + String.Format("${0:0.00}", postCoupon);
                btnAddCoupon.Enabled = false;
            }
            else if (txtCoupon.Text == "ten")
            {
                postCoupon = totalCurent * frmPizzaOrder.TEN;
                lblTotalAfterCoupon.Text = "After the coupon : " + String.Format("${0:0.00}", postCoupon);
                btnAddCoupon.Enabled = false;
            }
            else if (txtCoupon.Text == "twelve")
            {
                postCoupon = totalCurent * frmPizzaOrder.TWELVE;
                lblTotalAfterCoupon.Text = "After the coupon : " + String.Format("${0:0.00}", postCoupon);
                btnAddCoupon.Enabled = false;
            }
            else if (txtCoupon.Text == "fifteen")
            {
                postCoupon = totalCurent * frmPizzaOrder.FIFTEEN;
                lblTotalAfterCoupon.Text = "After the coupon : " + String.Format("${0:0.00}", postCoupon);
                btnAddCoupon.Enabled = false;
            }
            else if (txtCoupon.Text == "twentyfive")
            {
                postCoupon = totalCurent * frmPizzaOrder.TWENTY_FIVE;
                lblTotalAfterCoupon.Text = "After the coupon : " + String.Format("${0:0.00}", postCoupon);
                btnAddCoupon.Enabled = false;
            }
            else
            {
                MessageBox.Show("You have to put in a vaild code!!");
            }

        }

        //Tells the user to pay, then auto closes the entire program.
        private void btnProceed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your patronage! \nYour Order will be finished shortly \nPlease proceed to the counter to pay.");
            Thread.Sleep(100);

            Application.Exit();
        }
    }
}
