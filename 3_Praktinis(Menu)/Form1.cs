using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _3_Praktinis_Menu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Category> categories;
        List<Dish> dishes;
        Cart itemsCart = new Cart();

        public void CreateForm()
        {
            categories = new List<Category>();
            dishes = new List<Dish>();

            nameField.Visible = false;
            infoField.Visible = false;
            priceField.Visible = false;
            priceSign.Visible = false;
            addToCart.Visible = false;
            cart.Visible = false;

            string[] menu = File.ReadAllLines("kategorijos.txt", Encoding.Default);

            foreach (string word in menu)
            {
                string[] split = word.Split(':');

                if (split.Count() == 2)
                {
                    Category category = new Category(Convert.ToInt32(split[0]), Convert.ToString(split[1]));
                    categories.Add(category);
                }

            }

            menu = File.ReadAllLines("patiekalai.txt", Encoding.Default);

            foreach (string word in menu)
            {
                string[] split = word.Split(':');

                if (split.Count() == 6)
                {
                    Dish dish = new Dish(Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), Convert.ToString(split[2]), Convert.ToDouble(split[3]), Convert.ToString(split[4]), Convert.ToString(split[5]));
                    dishes.Add(dish);
                }
            }
            foreach (Category singleCat in categories)
            {
                Button newCat = new Button();
                newCat.Text = singleCat.categoryName;
                newCat.Width = 170;
                newCat.Height = 50;
                newCat.Tag = singleCat.categoryID;
                newCat.Parent = panel1;
                newCat.Location = new Point(0, (newCat.Height * (Convert.ToInt32(singleCat.categoryID) - 1)));
                newCat.Click += NewCat_Click;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateForm();
        }

        private void NewCat_Click(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32((sender as Button).Tag);
            panel2.Controls.Clear();
            int counter = 0;
            foreach (Dish singleDish in dishes)
            {
                if (singleDish.dishCategory == categoryID)
                {
                    Button newCat = new Button();
                    newCat.Text = singleDish.dishName;
                    newCat.Width = 170;
                    newCat.Height = 50;
                    newCat.Tag = singleDish.dishID;
                    newCat.Parent = panel2;
                    newCat.Location = new Point(0, (newCat.Height * counter));
                    counter++;
                    newCat.Click += Dish_Click1;
                }
            }
        }

        private void Dish_Click1(object sender, EventArgs e)
        {
            string dishName = Convert.ToString((sender as Button).Text);
            string dishInfo = Convert.ToString((sender as Button).Tag);
            foreach (Dish clickedDish in dishes)
            {
                if (clickedDish.dishName == dishName)
                {
                    nameField.Visible = true;
                    infoField.Visible = true;
                    pictureBox.Visible = true;
                    priceField.Visible = true;
                    priceSign.Visible = true;
                    addToCart.Visible = true;
                    cart.Visible = true;

                    nameField.Text = clickedDish.dishName;
                    nameField.Location = new Point(10, 15);
                    nameField.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
                    infoField.Text = clickedDish.dishInfo;
                    infoField.Font = new Font("Arial", 7, FontStyle.Italic);
                    priceField.Text = Convert.ToString(clickedDish.dishPrice);
                    priceField.Font = new Font("Microsoft Sans Serif", 17, FontStyle.Regular);
                    priceSign.Text = "€";
                    priceSign.Font = new Font("Microsoft Sans Serif", 17, FontStyle.Regular);
                    pictureBox.ImageLocation = clickedDish.dishPicture;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    addToCart.Text = "Pridėti į krepšelį";
                    addToCart.Height = 50;
                    addToCart.Width = 100;
                    cart.Text = "Krepšelis";
                    cart.Height = 50;
                    cart.Width = 100;

                }
            }
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            itemsCart.addItem(nameField.Text, Convert.ToDouble(priceField.Text));
            MessageBox.Show("Prekė pridėta į krepšelį");
        }

        public void cart_Click(object sender, EventArgs e)
        {
            Form2 cartWindow = new Form2(itemsCart);
            cartWindow.ShowDialog();
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            pictureBox.Image = null;
            addToCart.Visible = false;
            cart.Visible = false;
            CreateForm();
        }  
    }
}
