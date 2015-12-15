namespace Project10_Lunch_Orders
{
    partial class frmLunchOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpboxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.grpboxAddOnHamburger = new System.Windows.Forms.GroupBox();
            this.chkboxFries = new System.Windows.Forms.CheckBox();
            this.chkboxCondiments = new System.Windows.Forms.CheckBox();
            this.chkboxCalifornia = new System.Windows.Forms.CheckBox();
            this.grpboxAddOnPizza = new System.Windows.Forms.GroupBox();
            this.chkboxOlives = new System.Windows.Forms.CheckBox();
            this.chkboxSausage = new System.Windows.Forms.CheckBox();
            this.chkboxPepperoni = new System.Windows.Forms.CheckBox();
            this.grpboxAddOnSalad = new System.Windows.Forms.GroupBox();
            this.chkboxBreadSticks = new System.Windows.Forms.CheckBox();
            this.chkboxBaconBits = new System.Windows.Forms.CheckBox();
            this.chkboxCroutons = new System.Windows.Forms.CheckBox();
            this.grpboxOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpboxMainCourse.SuspendLayout();
            this.grpboxAddOnHamburger.SuspendLayout();
            this.grpboxAddOnPizza.SuspendLayout();
            this.grpboxAddOnSalad.SuspendLayout();
            this.grpboxOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxMainCourse
            // 
            this.grpboxMainCourse.Controls.Add(this.rdoSalad);
            this.grpboxMainCourse.Controls.Add(this.rdoPizza);
            this.grpboxMainCourse.Controls.Add(this.rdoHamburger);
            this.grpboxMainCourse.Location = new System.Drawing.Point(13, 13);
            this.grpboxMainCourse.Name = "grpboxMainCourse";
            this.grpboxMainCourse.Size = new System.Drawing.Size(123, 95);
            this.grpboxMainCourse.TabIndex = 0;
            this.grpboxMainCourse.TabStop = false;
            this.grpboxMainCourse.Text = "Main Course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(6, 65);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(88, 17);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.TabStop = true;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.ChangeAddonGroup);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(6, 42);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.TabStop = true;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.ChangeAddonGroup);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Location = new System.Drawing.Point(6, 19);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(113, 17);
            this.rdoHamburger.TabIndex = 0;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.ChangeAddonGroup);
            // 
            // grpboxAddOnHamburger
            // 
            this.grpboxAddOnHamburger.Controls.Add(this.chkboxFries);
            this.grpboxAddOnHamburger.Controls.Add(this.chkboxCondiments);
            this.grpboxAddOnHamburger.Controls.Add(this.chkboxCalifornia);
            this.grpboxAddOnHamburger.Location = new System.Drawing.Point(156, 13);
            this.grpboxAddOnHamburger.Name = "grpboxAddOnHamburger";
            this.grpboxAddOnHamburger.Size = new System.Drawing.Size(175, 95);
            this.grpboxAddOnHamburger.TabIndex = 1;
            this.grpboxAddOnHamburger.TabStop = false;
            this.grpboxAddOnHamburger.Text = "Add-on items($.75/each)";
            // 
            // chkboxFries
            // 
            this.chkboxFries.AutoSize = true;
            this.chkboxFries.Location = new System.Drawing.Point(7, 66);
            this.chkboxFries.Name = "chkboxFries";
            this.chkboxFries.Size = new System.Drawing.Size(81, 17);
            this.chkboxFries.TabIndex = 2;
            this.chkboxFries.Text = "French fries";
            this.chkboxFries.UseVisualStyleBackColor = true;
            this.chkboxFries.CheckedChanged += new System.EventHandler(this.ClearOrderTotals);
            // 
            // chkboxCondiments
            // 
            this.chkboxCondiments.AutoSize = true;
            this.chkboxCondiments.Location = new System.Drawing.Point(7, 42);
            this.chkboxCondiments.Name = "chkboxCondiments";
            this.chkboxCondiments.Size = new System.Drawing.Size(164, 17);
            this.chkboxCondiments.TabIndex = 1;
            this.chkboxCondiments.Text = "Ketchup, mustard, and  mayo";
            this.chkboxCondiments.UseVisualStyleBackColor = true;
            this.chkboxCondiments.CheckedChanged += new System.EventHandler(this.ClearOrderTotals);
            // 
            // chkboxCalifornia
            // 
            this.chkboxCalifornia.AutoSize = true;
            this.chkboxCalifornia.Location = new System.Drawing.Point(7, 20);
            this.chkboxCalifornia.Name = "chkboxCalifornia";
            this.chkboxCalifornia.Size = new System.Drawing.Size(158, 17);
            this.chkboxCalifornia.TabIndex = 0;
            this.chkboxCalifornia.Text = "Lettuce, tomato, and onions";
            this.chkboxCalifornia.UseVisualStyleBackColor = true;
            this.chkboxCalifornia.CheckedChanged += new System.EventHandler(this.ClearOrderTotals);
            // 
            // grpboxAddOnPizza
            // 
            this.grpboxAddOnPizza.Controls.Add(this.chkboxOlives);
            this.grpboxAddOnPizza.Controls.Add(this.chkboxSausage);
            this.grpboxAddOnPizza.Controls.Add(this.chkboxPepperoni);
            this.grpboxAddOnPizza.Location = new System.Drawing.Point(340, 13);
            this.grpboxAddOnPizza.Name = "grpboxAddOnPizza";
            this.grpboxAddOnPizza.Size = new System.Drawing.Size(175, 95);
            this.grpboxAddOnPizza.TabIndex = 2;
            this.grpboxAddOnPizza.TabStop = false;
            this.grpboxAddOnPizza.Text = "Add-on items($.50/each)";
            // 
            // chkboxOlives
            // 
            this.chkboxOlives.AutoSize = true;
            this.chkboxOlives.Location = new System.Drawing.Point(6, 66);
            this.chkboxOlives.Name = "chkboxOlives";
            this.chkboxOlives.Size = new System.Drawing.Size(55, 17);
            this.chkboxOlives.TabIndex = 2;
            this.chkboxOlives.Text = "Olives";
            this.chkboxOlives.UseVisualStyleBackColor = true;
            this.chkboxOlives.CheckedChanged += new System.EventHandler(this.ClearOrderTotals);
            // 
            // chkboxSausage
            // 
            this.chkboxSausage.AutoSize = true;
            this.chkboxSausage.Location = new System.Drawing.Point(6, 42);
            this.chkboxSausage.Name = "chkboxSausage";
            this.chkboxSausage.Size = new System.Drawing.Size(68, 17);
            this.chkboxSausage.TabIndex = 1;
            this.chkboxSausage.Text = "Sausage";
            this.chkboxSausage.UseVisualStyleBackColor = true;
            this.chkboxSausage.CheckedChanged += new System.EventHandler(this.ClearOrderTotals);
            // 
            // chkboxPepperoni
            // 
            this.chkboxPepperoni.AutoSize = true;
            this.chkboxPepperoni.Location = new System.Drawing.Point(6, 20);
            this.chkboxPepperoni.Name = "chkboxPepperoni";
            this.chkboxPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkboxPepperoni.TabIndex = 0;
            this.chkboxPepperoni.Text = "Pepperoni";
            this.chkboxPepperoni.UseVisualStyleBackColor = true;
            this.chkboxPepperoni.CheckedChanged += new System.EventHandler(this.ClearOrderTotals);
            // 
            // grpboxAddOnSalad
            // 
            this.grpboxAddOnSalad.Controls.Add(this.chkboxBreadSticks);
            this.grpboxAddOnSalad.Controls.Add(this.chkboxBaconBits);
            this.grpboxAddOnSalad.Controls.Add(this.chkboxCroutons);
            this.grpboxAddOnSalad.Location = new System.Drawing.Point(340, 118);
            this.grpboxAddOnSalad.Name = "grpboxAddOnSalad";
            this.grpboxAddOnSalad.Size = new System.Drawing.Size(175, 95);
            this.grpboxAddOnSalad.TabIndex = 2;
            this.grpboxAddOnSalad.TabStop = false;
            this.grpboxAddOnSalad.Text = "Add-on items($.25/each)";
            // 
            // chkboxBreadSticks
            // 
            this.chkboxBreadSticks.AutoSize = true;
            this.chkboxBreadSticks.Location = new System.Drawing.Point(7, 66);
            this.chkboxBreadSticks.Name = "chkboxBreadSticks";
            this.chkboxBreadSticks.Size = new System.Drawing.Size(81, 17);
            this.chkboxBreadSticks.TabIndex = 3;
            this.chkboxBreadSticks.Text = "Breadsticks";
            this.chkboxBreadSticks.UseVisualStyleBackColor = true;
            this.chkboxBreadSticks.CheckedChanged += new System.EventHandler(this.ClearOrderTotals);
            // 
            // chkboxBaconBits
            // 
            this.chkboxBaconBits.AutoSize = true;
            this.chkboxBaconBits.Location = new System.Drawing.Point(7, 42);
            this.chkboxBaconBits.Name = "chkboxBaconBits";
            this.chkboxBaconBits.Size = new System.Drawing.Size(77, 17);
            this.chkboxBaconBits.TabIndex = 1;
            this.chkboxBaconBits.Text = "Bacon Bits";
            this.chkboxBaconBits.UseVisualStyleBackColor = true;
            this.chkboxBaconBits.CheckedChanged += new System.EventHandler(this.ClearOrderTotals);
            // 
            // chkboxCroutons
            // 
            this.chkboxCroutons.AutoSize = true;
            this.chkboxCroutons.Location = new System.Drawing.Point(7, 20);
            this.chkboxCroutons.Name = "chkboxCroutons";
            this.chkboxCroutons.Size = new System.Drawing.Size(68, 17);
            this.chkboxCroutons.TabIndex = 0;
            this.chkboxCroutons.Text = "Croutons";
            this.chkboxCroutons.UseVisualStyleBackColor = true;
            this.chkboxCroutons.CheckedChanged += new System.EventHandler(this.ClearOrderTotals);
            // 
            // grpboxOrderTotal
            // 
            this.grpboxOrderTotal.Controls.Add(this.txtOrderTotal);
            this.grpboxOrderTotal.Controls.Add(this.txtTax);
            this.grpboxOrderTotal.Controls.Add(this.txtSubtotal);
            this.grpboxOrderTotal.Controls.Add(this.label3);
            this.grpboxOrderTotal.Controls.Add(this.label2);
            this.grpboxOrderTotal.Controls.Add(this.label1);
            this.grpboxOrderTotal.Location = new System.Drawing.Point(13, 125);
            this.grpboxOrderTotal.Name = "grpboxOrderTotal";
            this.grpboxOrderTotal.Size = new System.Drawing.Size(157, 100);
            this.grpboxOrderTotal.TabIndex = 3;
            this.grpboxOrderTotal.TabStop = false;
            this.grpboxOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(81, 72);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(59, 20);
            this.txtOrderTotal.TabIndex = 5;
            this.txtOrderTotal.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(81, 50);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(59, 20);
            this.txtTax.TabIndex = 4;
            this.txtTax.TabStop = false;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(81, 27);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(59, 20);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax (7.75%): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal: ";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(204, 125);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "&Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(204, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpboxOrderTotal);
            this.Controls.Add(this.grpboxAddOnPizza);
            this.Controls.Add(this.grpboxAddOnSalad);
            this.Controls.Add(this.grpboxAddOnHamburger);
            this.Controls.Add(this.grpboxMainCourse);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.grpboxMainCourse.ResumeLayout(false);
            this.grpboxMainCourse.PerformLayout();
            this.grpboxAddOnHamburger.ResumeLayout(false);
            this.grpboxAddOnHamburger.PerformLayout();
            this.grpboxAddOnPizza.ResumeLayout(false);
            this.grpboxAddOnPizza.PerformLayout();
            this.grpboxAddOnSalad.ResumeLayout(false);
            this.grpboxAddOnSalad.PerformLayout();
            this.grpboxOrderTotal.ResumeLayout(false);
            this.grpboxOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxMainCourse;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.GroupBox grpboxAddOnHamburger;
        private System.Windows.Forms.CheckBox chkboxFries;
        private System.Windows.Forms.CheckBox chkboxCondiments;
        private System.Windows.Forms.CheckBox chkboxCalifornia;
        private System.Windows.Forms.GroupBox grpboxAddOnPizza;
        private System.Windows.Forms.GroupBox grpboxAddOnSalad;
        private System.Windows.Forms.CheckBox chkboxOlives;
        private System.Windows.Forms.CheckBox chkboxSausage;
        private System.Windows.Forms.CheckBox chkboxPepperoni;
        private System.Windows.Forms.CheckBox chkboxBaconBits;
        private System.Windows.Forms.CheckBox chkboxCroutons;
        private System.Windows.Forms.CheckBox chkboxBreadSticks;
        private System.Windows.Forms.GroupBox grpboxOrderTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;

    }
}

