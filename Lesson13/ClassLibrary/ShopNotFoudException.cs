using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [System.Serializable]
    public class ShopNotFoudException : ApplicationException
    {
        public ShopNotFoudException(string shopName) : base($"Магазина с названием {shopName} не существует ")
        {

        }
        
    }
}
