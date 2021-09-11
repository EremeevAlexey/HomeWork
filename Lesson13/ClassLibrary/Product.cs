using System;

namespace ClassLibrary
{
    public struct Product
    {
        string name;
        string shopName;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ShopName
        {
            get { return shopName; }
            set { shopName = value; }
        }

        public static int CompareShops(Product firstShop, Product secondShop)
        {
            return string.Compare(firstShop.ShopName, secondShop.ShopName);
        }

    }
}
