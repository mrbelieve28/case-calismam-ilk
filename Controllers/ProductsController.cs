using casecalismam.Models;
using casecalismam.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace casecalismam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {

            var products = _productRepository.GetProducts();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            return Created("", _productRepository.Create(product));

        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(Product product, int id)
        {
            var p= _productRepository.GetProductById(id);
            if (p == null)
            {
                return NotFound();

            }

            p.Name = product.Name;
            p.Price = product.Price;
            p.Stok = product.Stok;

            _productRepository.UpdateProduct(p);

            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
			var p = _productRepository.GetProductById(id);
			if (p == null)
			{
				return NotFound();

			}

            _productRepository.DeleteProductById(id);

            return Ok("ürün başarıyla silinmiştir!");
		}

	}

    }

