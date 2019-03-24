namespace Assign5bPizzaOrderRChuIII
{
    partial class frmCoupons
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnAddCoupon = new System.Windows.Forms.Button();
            this.lblCurrentTotal = new System.Windows.Forms.Label();
            this.lblTotalAfterCoupon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do You Have Any Coupons?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "If so, Enter the code in the provided below (Max 1 coupon).\r\nIf not, proceed to c" +
    "heck out.\r\n";
            // 
            // txtCoupon
            // 
            this.txtCoupon.Location = new System.Drawing.Point(21, 132);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(368, 40);
            this.txtCoupon.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(395, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 43);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(21, 271);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(185, 60);
            this.btnProceed.TabIndex = 4;
            this.btnProceed.Text = "Continue";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnAddCoupon
            // 
            this.btnAddCoupon.Location = new System.Drawing.Point(21, 178);
            this.btnAddCoupon.Name = "btnAddCoupon";
            this.btnAddCoupon.Size = new System.Drawing.Size(203, 49);
            this.btnAddCoupon.TabIndex = 5;
            this.btnAddCoupon.Text = "Apply Coupon";
            this.btnAddCoupon.UseVisualStyleBackColor = true;
            this.btnAddCoupon.Click += new System.EventHandler(this.btnAddCoupon_Click);
            // 
            // lblCurrentTotal
            // 
            this.lblCurrentTotal.AutoSize = true;
            this.lblCurrentTotal.Location = new System.Drawing.Point(246, 185);
            this.lblCurrentTotal.Name = "lblCurrentTotal";
            this.lblCurrentTotal.Size = new System.Drawing.Size(166, 34);
            this.lblCurrentTotal.TabIndex = 6;
            this.lblCurrentTotal.Text = "Your Total Is : ";
            // 
            // lblTotalAfterCoupon
            // 
            this.lblTotalAfterCoupon.AutoSize = true;
            this.lblTotalAfterCoupon.Location = new System.Drawing.Point(246, 219);
            this.lblTotalAfterCoupon.Name = "lblTotalAfterCoupon";
            this.lblTotalAfterCoupon.Size = new System.Drawing.Size(213, 34);
            this.lblTotalAfterCoupon.TabIndex = 7;
            this.lblTotalAfterCoupon.Text = "After the coupon : ";
            // 
            // frmCoupons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 354);
            this.Controls.Add(this.lblTotalAfterCoupon);
            this.Controls.Add(this.lblCurrentTotal);
            this.Controls.Add(this.btnAddCoupon);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCoupon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "frmCoupons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Do you Have any Coupons?";
            this.Load += new System.EventHandler(this.frmCoupons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnAddCoupon;
        private System.Windows.Forms.Label lblCurrentTotal;
        private System.Windows.Forms.Label lblTotalAfterCoupon;
    }
}