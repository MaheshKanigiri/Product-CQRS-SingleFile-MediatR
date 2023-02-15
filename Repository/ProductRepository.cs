using Product_CQRS_SingleFile_MediatR.Interface;
using Product_CQRS_SingleFile_MediatR.Models;

namespace Product_CQRS_SingleFile_MediatR.Repository
{
    public class ProductRepository : IProduct
    {

        private readonly ProductdbContext _context;
        public ProductRepository(ProductdbContext context)
        {
            _context = context;
        }

        public  List<Product> CreateProducts(Product product)
        {

            _context.Products.Add(product);
            _context.SaveChanges();
            return _context.Products.ToList();
        }

        public string DeleteProduct(int Id)
        {
            var oldData = _context.Products.FirstOrDefault(x => x.Id == Id);

            if (oldData != null)
            {

                _context.Products.Remove(oldData);
                _context.SaveChanges();
            }
            return "Product with ID:"+Id+" was sucessful!";
        }

        public Product GetProductById(int Id)
        {
            throw new NotImplementedException();
        }

        public  List<Product> GetProducts()
        {
            return   _context.Products.ToList();
        }

        public  List<Product> updateProduct(Product product)
        {
            var productUpdate = _context.Products.Find(product.Id);

            if (productUpdate != null)
            {
                productUpdate.ProductCategory = product.ProductCategory;
                productUpdate.ProductPrice = product.ProductPrice;
                productUpdate.ProductDescription= product.ProductDescription;
                productUpdate.ProductName = product.ProductName;
            }

            return  _context.Products.ToList();
        }
    }
}
