using Product_CQRS_SingleFile_MediatR.Models;

namespace Product_CQRS_SingleFile_MediatR.Interface
{
    public interface IProduct
    {
        //GET-PRODUCTS
        public List<Product> GetProducts();
        //GET-PRODUCTS-BY-ID
        public Product GetProductById(int Id);
        //CREATE[POST]-NEW-PRODUCT
        public List<Product> CreateProducts(Product product);
        //DELETE-PRODUCT
        public String DeleteProduct(int Id);
        //UPDATE-[PUT] PRODUCT
        public List<Product> updateProduct(Product product);
    }
}
