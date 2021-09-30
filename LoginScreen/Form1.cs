using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1: Form
    {
        double slicePrice = 3.25;
        //double totalPrice;
        int numOfSlices = 0;

        double subtotal = 0;
        double totalPrice = 0;

        double taxRate = 0.13;
        double taxAmount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
               // username = slicesInput.Text;
                numOfSlices = Convert.ToInt32(slicesInput.Text);

                //subtotal = numOfSlices * slicePrice;
               // taxAmount = subtotal * taxRate;
               // totalPrice = subtotal * taxAmount;

              //  subtotalOutput.Text = subtotal.ToString("C");
               // taxOutput.Text = taxAmount.ToString("C");
                //totalOutput.Text = totalPrice.ToString("C");
               
                totalPrice = numOfSlices * slicePrice;
                outputLabel.Text = $"The price of {numOfSlices} slices is {totalPrice.ToString("C")}";


                // welcome the user with their name
               //  outputLabel.Text = $"Welcome {slices}";
            }
            catch
            { 
               // subtotalOutput.Text = "Input Error";
               // taxRate.
                outputLabel.Text = "Please enter only whole numbers for the number of slices required.";
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {

            // wejhgdffgfbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbblcome the user with their name
            //  outputLabel.Text = $"Welcome ADMIN user {username}";
        }
       
    }
}
