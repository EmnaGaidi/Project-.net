using project.Models;

namespace project.Data
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> getAllProducts();
        IEnumerable<Product> getProductBySingerName(string singer);
        IEnumerable<Product> GetProductByPrice(float price);
        IEnumerable<Product> GetProductByRelease_Date(string date);
        IEnumerable<Product> GetProductByType(string type);
        IEnumerable<Product> GetAlbumByPrice(float price);
        IEnumerable<Product> GetSingleByPrice(float price);
        IEnumerable<Product> GetProductByGenre(string genre);
        IEnumerable<Product> GetAlbumByGenre(string genre);

        IEnumerable<Product> GetSingleByGenre(string genre);



    }
}
