using casecalismam.Models;
using System.Collections.Generic;

namespace casecalismam.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        
        Product GetProductById(int id);

        Product Create(Product product);

        void DeleteProductById(int id);

		Product UpdateProduct(Product product);
	}
}
