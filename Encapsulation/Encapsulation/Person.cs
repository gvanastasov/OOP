using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        private decimal money;
        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Money cannot be negative.");
                }

                this.money = value;
            }
        }

        private List<Product> products;
        public IReadOnlyList<Product> Products
        {
            get
            {
                return this.Products;
            }
        }

        public void BuyProduct(Product product)
        {
            this.Money -= product.Cost;
            this.products.Add(product);
        }

        public string GetCart()
        {
            return products.Count == 0
                ? "Nothing bought" 
                : string.Join(", ", this.products.Select(p => p.Name));
        }
    }
}
