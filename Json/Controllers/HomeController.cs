using Json.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Json.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index(int id, string name)     // https://localhost:44389/Home/index/1 an https://localhost:44389/Home/index/1/Paata
    {                                                  // RouteConfig -ში name დავამატეთ
      ViewBag.id = id;                                 // თუ RouteConfig-ში არ შევცვლიდით მაშინ ასე შეგვეძლო არგუმენტების გადაცემა /Home/index/?id=1&name=Paata
      ViewBag.name = name;

      return View();
    }


    public JsonResult GetDat()         //  https://localhost:44389/Home/Getdat
    {
      MyDbDataContext db = new MyDbDataContext();
      List<User> userList = new List<User>();
      userList = db.Users.Where(x => x.Id > -1).ToList();

      return Json(userList, JsonRequestBehavior.AllowGet);
    }



    //public ActionResult About()
    //{
    //  ViewBag.Message = "Your application description page.";

    //  return View();
    //}

    //public ActionResult Contact()
    //{
    //  ViewBag.Message = "Your contact page.";

    //  return View();
    //}
  }
}