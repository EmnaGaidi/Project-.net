using Microsoft.AspNetCore.Mvc;
using project.Data;

namespace project.Controllers
{
    public class AlbumsController : Controller
    {
        public ActionResult Index()
        {
            ProjectContext Context = ProjectContext.Instance;
            IProductRepository ProductRep = new ProductRepository(Context);
            return View(ProductRep.GetProductByType("album"));
        }
        public ActionResult AlbumByPrice(float price)
        {
            ProjectContext Context = ProjectContext.Instance;
            IProductRepository ProductRep = new ProductRepository(Context);
            return View(ProductRep.GetAlbumByPrice(price));
        }
        public ActionResult AlbumByGenre(string genre)
        {
            ProjectContext Context = ProjectContext.Instance;
            IProductRepository ProductRep = new ProductRepository(Context);
            return View(ProductRep.GetAlbumByGenre(genre));
        }
    }
}
