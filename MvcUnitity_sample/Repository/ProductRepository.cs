using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace MvcUnitity_sample.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepository()
        {
            // Adds products for demonstration
            Add(new Product {Name = "computer", Category = "Electronics", Price = 23.5M});
            Add(new Product { Name = "laptop", Category = "Electronics", Price = 33.5M });
            Add(new Product { Name = "iPhone4", Category = "Phone", Price = 16.5M });

        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentException("item");
            }

            item.Id = _nextId++;
            products.Add(item);

            return item;
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentException("item");
            }

            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }

            products.RemoveAt(index);
            products.Add(item);

            return true;
        }

        public bool Delete(int id)
        {
            products.RemoveAll(p => p.Id == id);

            return true;
        }
    }
}