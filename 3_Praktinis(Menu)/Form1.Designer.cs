namespace _3_Praktinis_Menu_
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.priceSign = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.Label();
            this.infoField = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nameField = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cart = new System.Windows.Forms.Button();
            this.addToCart = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 442);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(262, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 442);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.priceSign);
            this.panel3.Controls.Add(this.priceField);
            this.panel3.Controls.Add(this.infoField);
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Controls.Add(this.nameField);
            this.panel3.Location = new System.Drawing.Point(512, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 466);
            this.panel3.TabIndex = 2;
            // 
            // priceSign
            // 
            this.priceSign.AutoSize = true;
            this.priceSign.Location = new System.Drawing.Point(342, 25);
            this.priceSign.Name = "priceSign";
            this.priceSign.Size = new System.Drawing.Size(40, 17);
            this.priceSign.TabIndex = 4;
            this.priceSign.Text = "Price";
            // 
            // priceField
            // 
            this.priceField.AutoSize = true;
            this.priceField.Location = new System.Drawing.Point(374, 25);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(40, 17);
            this.priceField.TabIndex = 3;
            this.priceField.Text = "Price";
            // 
            // infoField
            // 
            this.infoField.AutoSize = true;
            this.infoField.Location = new System.Drawing.Point(18, 55);
            this.infoField.Name = "infoField";
            this.infoField.Size = new System.Drawing.Size(31, 17);
            this.infoField.TabIndex = 2;
            this.infoField.Text = "Info";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(9, 86);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(463, 336);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // nameField
            // 
            this.nameField.AutoSize = true;
            this.nameField.Location = new System.Drawing.Point(19, 16);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(45, 17);
            this.nameField.TabIndex = 0;
            this.nameField.Text = "Name";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cart);
            this.panel4.Controls.Add(this.addToCart);
            this.panel4.Location = new System.Drawing.Point(1000, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 442);
            this.panel4.TabIndex = 3;
            // 
            // cart
            // 
            this.cart.Location = new System.Drawing.Point(6, 179);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(75, 23);
            this.cart.TabIndex = 1;
            this.cart.Text = "button1";
            this.cart.UseVisualStyleBackColor = true;
            this.cart.Click += new System.EventHandler(this.cart_Click);
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(6, 90);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(75, 23);
            this.addToCart.TabIndex = 0;
            this.addToCart.Text = "button1";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 482);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label infoField;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label nameField;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label priceField;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.Label priceSign;
    }
}

