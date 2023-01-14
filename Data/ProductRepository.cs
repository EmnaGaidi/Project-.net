using project.Models;

namespace project.Data
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ProjectContext context1;
        public ProductRepository(ProjectContext context) : base(context)
        {
            this.context1 = context;
        }

        public IEnumerable<Product> GetAlbumByGenre(string genre)
        {
            return context1.Product.Where(a => a.type == "album").Where(s => s.genre == genre).ToList();

        }

        public IEnumerable<Product> GetAlbumByPrice(float price)
        {
            return context1.Product.Where(s => s.price <= price).Where(a => a.type == "album").ToList();
        }

        public IEnumerable<Product> getAllProducts()
        {
            return context1.Product.ToList();
        }

        public IEnumerable<Product> GetProductByGenre(string genre)
        {
            return context1.Product.Where(s => s.genre == genre).ToList();
        }

        public IEnumerable<Product> GetProductByPrice(float price)
        {
            return context1.Product.Where(s => s.price <= price).ToList();
        }

        public IEnumerable<Product> GetProductByRelease_Date(string release_date)
        {
            return context1.Product.Where(s => s.release_date == release_date).ToList();
        }


        public IEnumerable<Product> getProductBySingerName(string singer)
        {
            return context1.Product.Where(s => s.singer == singer).ToList();
        }

        public IEnumerable<Product> GetProductByType(string type)
        {
            return context1.Product.Where(s => s.type == type).ToList();
        }

        public IEnumerable<Product> GetSingleByGenre(string genre)
        {
            return context1.Product.Where(a => a.type == "single").Where(s => s.genre == genre).ToList();
        }

        public IEnumerable<Product> GetSingleByPrice(float price)
        {
            return context1.Product.Where(s => s.price <= price).Where(a => a.type == "single").ToList();
        }
    }
}
