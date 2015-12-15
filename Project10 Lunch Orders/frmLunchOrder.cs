using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_Lunch_Orders
{
    public partial class frmLunchOrder : Form
    {
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        public decimal subtotal = 0m;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Method to clear the totals
        private void ClearOrderTotals(object sender, EventArgs e)
        {
            txtOrderTotal.Clear();
            txtSubtotal.Clear();
            txtTax.Clear();
        }

        //Method to clear all checkboxes.  Loops through and finds each groupbox, then unchecks
        //each checkbox
        private void ClearCheckBoxes()
        {
            foreach(Control C in this.Controls)
                if(C is GroupBox)
                {
                    foreach(CheckBox chkbox in C.Controls.OfType<CheckBox>())
                        {
                            chkbox.Checked = false;
                        }
                }


        }

        private void ChangeAddonGroup(object sender, EventArgs e)
        {
            //switches which group box is displayed based on which main course
            //is selected. Can't get them to stack up in the same spot unfortunately
            //but I will look into it further.  For now, they are placed in different
            //locations and only visible when the appropriate course is selected
            ClearCheckBoxes();
            ClearOrderTotals();
            
            RadioButton rdoBtn = sender as RadioButton;

            switch (rdoBtn.Name)
            {
                case "rdoHamburger":
                grpboxAddOnHamburger.Visible = true;
                grpboxAddOnPizza.Visible = false;
                grpboxAddOnSalad.Visible = false;
                break;

                case "rdoPizza":
                grpboxAddOnHamburger.Visible = false;
                grpboxAddOnPizza.Visible = true;
                grpboxAddOnPizza.BringToFront();
                grpboxAddOnSalad.Visible = false;
                break;

                case "rdoSalad":
                grpboxAddOnHamburger.Visible = false;
                grpboxAddOnPizza.Visible = false;
                grpboxAddOnSalad.Visible = true;
                break;
                
            }
        }

        //Calculates the subtotal based on checkmarks that are checked and the 
        //base price for each item
        public decimal CalculateSubtotal()
        {
            subtotal = 0m;
            foreach(Control C in this.Controls)
                if(C is GroupBox)
                {
                    if (C.Name == "grpboxAddOnHamburger")
                    {
                        foreach (CheckBox chkbox in C.Controls.OfType<CheckBox>())
                        {
                            if (chkbox.Checked == true)
                            {
                                subtotal += .75m;
                            }
                        }
                    }
                    else if(C.Name == "grpboxAddOnPizza")
                    {
                        foreach (CheckBox chkbox in C.Controls.OfType<CheckBox>())
                        {
                            if (chkbox.Checked == true)
                            {
                                subtotal += .50m;
                            }
                        }
                    }
                    else if (C.Name == "grpboxAddOnSalad")
                    {
                        foreach (CheckBox chkbox in C.Controls.OfType<CheckBox>())
                        {
                            if (chkbox.Checked == true)
                            {
                                subtotal += .25m;
                            }
                        }
                    }
                }

            if (rdoHamburger.Checked == true)
                subtotal += 6.95m;
            else if (rdoPizza.Checked == true)
                subtotal += 5.95m;
            else if (rdoSalad.Checked == true)
                subtotal += 4.95m;

            return subtotal;
        
        }

        //calculates the tax
        private decimal CalculateTax(decimal subtotal)
        {
            decimal tax = subtotal * .0775m;
            return tax;
        }

        //adds tax and subtotal to get the total
        private decimal CalculateTotal(decimal subtotal, decimal tax)
        {
            decimal total = tax + subtotal;
            return total;
        }

        //writes the information to the appropriate boxes
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal subtotal = CalculateSubtotal();
            txtSubtotal.Text = subtotal.ToString("c");
            decimal tax = CalculateTax(subtotal);
            txtTax.Text = tax.ToString("c");
            decimal total = CalculateTotal(subtotal, tax);
            txtOrderTotal.Text = total.ToString("c");

        }

        private void ClearOrderTotals()
        {

        }


    }
}
