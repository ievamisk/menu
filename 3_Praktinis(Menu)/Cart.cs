using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Praktinis_Menu_
{
    public class Cart
    {
        List<string> items = new List<string>();
        List<int> itemsAmount = new List<int>();
        List<double> itemsPrice = new List<double>();

        private bool itemExists(string itemName)
        {
            bool exists = false;
            if (items.Contains(itemName))
            {
                exists = true;
            }
            return exists;
        }

        public void addItem(string itemName, double price)
        {
            if (!itemExists(itemName))
            {
                items.Add(itemName);
                itemsAmount.Add(1);
                itemsPrice.Add(price);
            }
            else
            {
                int itemPosition = items.IndexOf(itemName);
                itemsAmount[itemPosition] += 1; 
            }
        }

        private double getItemFullPrice(int itemPosition)
        {
            return Convert.ToDouble(itemsPrice[itemPosition] * itemsAmount[itemPosition]);
        }

        public List<string> getFullList()
        {
            List<string> cartInfoList = new List<string>();
            for (int i = 0; i < items.Count; i++)
            {
                string itemInfo = items[i] + " : ";
                itemInfo += itemsPrice[i].ToString() + "€   |   ";
                itemInfo += "x" + itemsAmount[i].ToString() + "   |   ";
                itemInfo += getItemFullPrice(i).ToString() + "€";
                cartInfoList.Add(itemInfo);
            }
            return cartInfoList;
        }

        public string Total()
        {
            double sum = 0;
            for (int i = 0; i < items.Count; i++)
            {
                sum += Convert.ToDouble(itemsPrice[i] * itemsAmount[i]);
            }
            return sum.ToString();
        }
    }
}
