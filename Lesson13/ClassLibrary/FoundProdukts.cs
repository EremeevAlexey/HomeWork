using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FoundProdukts
    {
        string result;

        public string Result => result;


        public void FoundProdukt(Product[] products, string checkShop)
        {

            foreach (var productInShop in products)
            {
                if (productInShop.ShopName == checkShop)
                {
                    result = $"\nВ магазине {productInShop.ShopName} продается {productInShop.Produkt}";                    
                }
                
            }
            if (result == null)
                throw new ShopNotFoudException(checkShop);

        }

    }
}
