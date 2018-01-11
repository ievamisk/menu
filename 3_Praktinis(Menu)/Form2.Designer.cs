namespace _3_Praktinis_Menu_
{
    partial class Form2
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
            this.totalPriceField = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.cartListName = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalPriceField
            // 
            this.totalPriceField.AutoSize = true;
            this.totalPriceField.Location = new System.Drawing.Point(151, 200);
            this.totalPriceField.Name = "totalPriceField";
            this.totalPriceField.Size = new System.Drawing.Size(46, 17);
            this.totalPriceField.TabIndex = 1;
            this.totalPriceField.Text = "label1";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(136, 229);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 2;
            this.payButton.Text = "button1";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // cartListName
            // 
            this.cartListName.AutoSize = true;
            this.cartListName.Location = new System.Drawing.Point(145, 33);
            this.cartListName.Name = "cartListName";
            this.cartListName.Size = new System.Drawing.Size(56, 17);
            this.cartListName.TabIndex = 3;
            this.cartListName.Text = "Prekės:";
            // 
            // itemsListBox
            // 
            this.itemsListBox.AutoSize = true;
            this.itemsListBox.BackColor = System.Drawing.SystemColors.Window;
            this.itemsListBox.Location = new System.Drawing.Point(151, 66);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(46, 17);
            this.itemsListBox.TabIndex = 5;
            this.itemsListBox.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 296);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.cartListName);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.totalPriceField);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krepšelis";
            
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalPriceField;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label cartListName;
        private System.Windows.Forms.Label itemsListBox;
    }
}