using System.Collections.Generic;
using BusinessEntities;

namespace Data.Repositories
{
    public interface IProductRepository
    {
        Product Get(int Id);

        IEnumerable<Product> GetProducts();
        //void DeleteAll();

        Product Create(Product product);

        Product Update(Product product);

        void Delete(int id);
    }
}
