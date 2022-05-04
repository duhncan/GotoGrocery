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
            public Inventory()
            {
                
            }

            public int validateProduct(string _productname, int _inventorylevel, string  _productsize, int _shelfquantity, int _orderamount)
            {
                //check strings not empty and counts not less than or equal to zero
                if (_productname == "")
                {
                    return 1;
                }
                else if (_inventorylevel <= 0)
                {
                    return 2;
                }
                else if (_productsize == "")
                {
                    return 3;
                }
                else if (_shelfquantity <= 0)
                {
                    return 4;
                }
                else if(_orderamount <= 0)
                {
                    return 5;
                }

                //All tests pass
                return 0;       
            }
        }
    }
}
