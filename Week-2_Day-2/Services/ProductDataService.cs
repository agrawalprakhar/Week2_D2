using Week_2_Day_2.Interfaces;
using Week_2_Day_2.Models;

namespace Week_2_Day_2.Services
{
    public class ProductDataService : IProductDataService
    {
        private readonly List<Product> _products;
        public ProductDataService()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 799.99M },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99M },
                new Product { Id = 3, Name = "Headphones", Price = 89.99M },
                new Product { Id = 4, Name = "Monitor", Price = 349.99M },
                new Product { Id = 5, Name = "Wireless Mouse", Price = 29.99M },
                new Product { Id = 6, Name = "Keyboard", Price = 69.99M },
                new Product { Id = 7, Name = "External Hard Drive", Price = 129.99M },
                new Product { Id = 8, Name = "Tablet", Price = 299.99M },
                new Product { Id = 9, Name = "Gaming Console", Price = 399.99M },
                new Product { Id = 10, Name = "Wireless Earbuds", Price = 149.99M }
            };
        }
        // it retun all list of products
        public List<Product> GetProducts()
        {
            return _products.ToList();
        }

        // It return product by it's id
        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id)!;
        }

        // It add a product to list
        public void AddProduct(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }

        // It update a product from list 
        public void UpdateProduct(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
        }

        // It delete a product from list
        public bool DeleteProduct(int id)
        {
            var productToDelete = _products.FirstOrDefault(p => p.Id == id);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);             
            }
            return true;
        }
    }
}
