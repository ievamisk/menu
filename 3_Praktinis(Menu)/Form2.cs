using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Praktinis_Menu_
{
    public partial class Form2 : Form
    {

        private bool isPaid = false;

        public Form2(Cart items)
        {
            InitializeComponent();
            itemsCart = items;
        }

        Cart itemsCart = new Cart();

        public void Form2_Load(object sender, EventArgs e)
        {
            string items = "";
            foreach (string itemThing in itemsCart.getFullList())
            {
                items += itemThing + "\n";
            }
            itemsListBox.Text = items;
            cartListName.Location = new Point(20, 30);
            cartListName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            itemsListBox.Location = new Point(20, 50);
            totalPriceField.Location = new Point(20, 150);
            totalPriceField.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            totalPriceField.Text = "Iš viso:  " + itemsCart.Total() + " €";
            payButton.Location = new Point(85, 180);
            payButton.Height = 40;
            payButton.Width = 100;
            payButton.Text = "Apmoketi";

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apmokėjimas sėkmingas!");
            isPaid = true;
            this.Close();
        }
    }
}
