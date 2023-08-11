using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Product
    {
        private int _id;
        private string _name;
        private int _price;
        private int _discountPercent;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public int DiscountPercent { get { return _discountPercent; } set { _discountPercent = value; } }
        
        public Product(int id,string name,int price,int discountPercent) 
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercent = discountPercent;
        }
        public string PrintDetails()
        {
            return $"\nId: {ID}\nName: {Name}\nPrice: {Price}\nDiscount: {DiscountPercent}%";
        }
        public int DiscountedPrice()
        {
            return Price-Price*DiscountPercent/100;
        }
    }
}
