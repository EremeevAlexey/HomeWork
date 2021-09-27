using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Compare
    {
        public int CompareShops(Product firstShop, Product secondShop)
        {
            return string.Compare(firstShop.ShopName, secondShop.ShopName);
        }
    }
}
