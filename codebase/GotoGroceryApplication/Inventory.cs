using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using GoToGrocery;

namespace GoToGrocery
{
    class Inventory
    {
        public Inventory()
        {
            
        }
        public int validateProduct(string _productname, string _inventorylevel, string  _productsize, string _shelfquantity, string _orderamount)
        {
            //Check name contains characters
            if (!Regex.IsMatch(_productname, @"(\w+)"))
            {
                return 1;
            }

            //Check inventory is only digits
            if (!Regex.IsMatch(_inventorylevel, @"\d+"))
            {
                return 2;
            }

            //Check product is is digits then space then letters, eg. "200 ml"
            if (!Regex.IsMatch(_productsize, @"\d+\s\w+"))
            {
                return 3;
            }

            //Check shelf quantity is digits
            if (!Regex.IsMatch(_shelfquantity, @"\d+"))
            {
                return 4;
            }

            //Check order amount is digits
            if (!Regex.IsMatch(_orderamount, @"\d+"))
            {
                return 5;
            }

            //All tests pass
            return 0;       
        }
    }
}
