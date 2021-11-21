using Basket.Models;
using System;
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
      MydbDataContext db = new MydbDataContext();

      user_cart uc = new user_cart()
      {
        ProductId = id,
        Price = db.product_news.Where(x => x.Id == id).Select(x => x.Price).FirstOrDefault(),
        CreateDate = DateTime.Now,
        UserId = 1
      };

      db.user_carts.InsertOnSubmit(uc);
      db.SubmitChanges();

      return Json(true, JsonRequestBehavior.AllowGet);
    }
  }
}