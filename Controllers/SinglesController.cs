using Microsoft.AspNetCore.Mvc;
using project.Data;

namespace project.Controllers
{
    public class SinglesController : Controller
    {
        public ActionResult Index()
        {
            ProjectContext Context = ProjectContext.Instance;
            IProductRepository ProductRep = new ProductRepository(Context);
            return View(ProductRep.GetProductByType("single"));
        }

        [HttpPost]
        public ActionResult SingleByPrice(float price)
        {
            ProjectContext Context = ProjectContext.Instance;
            IProductRepository ProductRep = new ProductRepository(Context);
            return View(ProductRep.GetSingleByPrice(price));
        }
        public ActionResult SingleByGenre(string genre)
        {
            ProjectContext Context = ProjectContext.Instance;
            IProductRepository ProductRep = new ProductRepository(Context);
            return View(ProductRep.GetSingleByGenre(genre));
        }

    }
}
