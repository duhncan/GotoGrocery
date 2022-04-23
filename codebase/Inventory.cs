using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoGrocery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace GoToGrocery
    {
        class Inventory
        {
            private DatabaseConnection db;

            public Inventory()
            {
                
            }

            //change this to return an int, value of int is determined by which input failed the check
            public bool validateProduct(string _productname, int _inventorylevel, string  _productsize, int _shelfquantity, int _orderamount)
            {
                DatabaseConnection db = new DatabaseConnection();

                //check strings not empty and counts not less than or equal to zero
                if (_productname == "" || _inventorylevel <= 0 || _productsize == "" || _shelfquantity <= 0 || _orderamount <= 0)
                {
                    db.AddProduct(_productname, _inventorylevel, _productsize, _shelfquantity, _orderamount);
                    return true;
                }
                return false;
            }
            

            // inventory class should take data from gui, check it for integrity/verification purposes, then send to the databse class to be uploaded to the database
            //// To iterate over it.
            //foreach (List<string> subList in myList)
            //{
            //    foreach (string item in subList)
            //    {
            //        //put csv export stuff in here
            //        Console.WriteLine(item);
            //    }
            //}


            //after input checking, add to database with this:

        }
    }

}
