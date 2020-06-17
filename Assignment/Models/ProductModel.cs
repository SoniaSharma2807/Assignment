using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            this.products = new List<Product>() {
                new Product {
                    Id = "p01",
                    Name = "Name 1",
                    Price = 5
                },
                new Product {
                    Id = "p02",
                    Name = "Name 2",
                    Price = 2
                },
                new Product {
                    Id = "p03",
                    Name = "Name 3",
                    Price = 6
                }
            };
        }

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(string id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }
    }
}
