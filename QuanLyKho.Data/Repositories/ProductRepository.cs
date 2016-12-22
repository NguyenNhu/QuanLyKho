using QuanLyKho.Data.Infrastructure;
using QuanLyKho.Model.Models;

namespace QuanLyKho.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}