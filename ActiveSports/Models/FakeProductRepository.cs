using System.Collections.Generic;
using System.Linq;

namespace ActiveSports.Models
{
    public class FakeProductRepository/*: IProductRepository */
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Ortiz Signature Model Football", Price = 25 },
            new Product { Name = "Surfboard", Price = 175},
            new Product { Name = "Running Shoes", Price = 95},
        }.AsQueryable<Product>();
    }
}
