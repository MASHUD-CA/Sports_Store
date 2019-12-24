using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository //IProductRepo auto create FakePorductRepo = dependancy injection
    //Fake coz we hardcoding for product
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name = "Football", Price = 25},
            new Product {Name = "Surf board", Price = 179},
            new Product {Name = "Running shoes", Price = 195},

        }.AsQueryable<Product>(); // Convert above list to IQueryable and type is product

    }
}
