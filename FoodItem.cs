using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBankInventory
{
    public class FoodItem
    {
        public String name;
        public String category;
        public int quantity = 0;
        public String expirationDate;

        public FoodItem(string name, string category, int quantity, string expirationDate)
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
        }

        public override string ToString()
        {
            return "Name: " + name + ", Category: " + category + ", Quantity: " + quantity + ", Expiration Date: " + expirationDate;
        }
    }
}
