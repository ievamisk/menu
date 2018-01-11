using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Praktinis_Menu_
{
    class Dish
    {
        public int dishID;
        public int dishCategory;
        public string dishName;
        public double dishPrice;
        public string dishInfo;
        public string dishPicture;

        public Dish(int ID, int category, string name, double price, string info, string picture)
        {
            dishID = ID;
            dishCategory = category;
            dishName = name;
            dishPrice = price;
            dishInfo = info;
            dishPicture = picture;
        }
     }
}
