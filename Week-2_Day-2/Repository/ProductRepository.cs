using Week_2_Day_2.Interfaces;
using Week_2_Day_2.Models;

namespace Week_2_Day_2.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductDataService _productContext;
        public ProductRepository(IProductDataService productContext)
        {
            _productContext = productContext;
        }

        /// <summary>
        /// it return list of products
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {
            return  _productContext.GetProducts();
        }

        /// <summary>
        /// It return product by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id)
        {
            return _productContext.GetProductById(id);
        }

        /// <summary>
        /// it add a product to list
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            _productContext.AddProduct(product);
        }

        /// <summary>
        /// it update product based on user input
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(Product product)
        {
            _productContext.UpdateProduct(product);
        }

        /// <summary>
        /// it delete product from list
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true if successfully delete else false</returns>
        public bool DeleteProduct(int id)
        {
           bool isDeleted = _productContext.DeleteProduct(id);
           return isDeleted;
        }
    }
}
