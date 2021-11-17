using Basket.Models;
using System.Linq;
using System.Web.Mvc;


namespace Basket.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      MydbDataContext mydbDataContext = new MydbDataContext();

      return View(mydbDataContext.product_news.ToList());
    }

    [HttpPost]
    public JsonResult Index(int id)
    {


      return Json();
    }
  }
}