using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSelling.Models
{
    class Product
    {
        private string _name;
        public double Price;
        public int Count;
        public double TotalIncome;
        public string  Name {
            get
            {
                return _name;
            }
            set
            {
                if(!(string.IsNullOrWhiteSpace(value)))
                {
                    this._name = value;
                }
                else
                {
                    Console.WriteLine("Enter the name of product:");
                }
            }
        }

        public void Sell()
        {
            if (Count>0) {
                Count --;
                TotalIncome += Price;
            }
            else
            {
                Console.WriteLine($"{Name} mehsulundan artiq qalmayib.");
            }
            
        }
    }
}
