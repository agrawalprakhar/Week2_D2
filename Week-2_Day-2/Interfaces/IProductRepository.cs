using Week_2_Day_2.Models;

namespace Week_2_Day_2.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// it return list of products
        /// </summary>
        /// <returns></returns>
        List<Product> GetAllProducts();

        /// <summary>
        /// It return product by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product GetProductById(int id);

        /// <summary>
        /// it add a product to list
        /// </summary>
        /// <param name="product"></param>
        void AddProduct(Product product);

        /// <summary>
        /// it update product based on user input
        /// </summary>
        /// <param name="product"></param>
        void UpdateProduct(Product product);

        /// <summary>
        /// it delete product from list
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true if successfully delete else false</returns>
        bool DeleteProduct(int id);
    }
}
