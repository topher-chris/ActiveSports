using System.Linq;

namespace ActiveSports.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
