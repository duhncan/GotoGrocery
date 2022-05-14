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
            //check strings not empty and counts not less than or equal to zero
            if (!Regex.IsMatch(_productname, @"(\w+)"))
            {
                return 1;
            }

            if (!Regex.IsMatch(_inventorylevel, @"\d+"))
            {
                return 2;
            }

            if (!Regex.IsMatch(_productsize, @"\d+\s\w+"))
            {
                return 3;
            }

            if (!Regex.IsMatch(_shelfquantity, @"\d+"))
            {
                return 4;
            }

            if (!Regex.IsMatch(_orderamount, @"\d+"))
            {
                return 5;
            }

            //All tests pass
            return 0;       
        }
    }
}
