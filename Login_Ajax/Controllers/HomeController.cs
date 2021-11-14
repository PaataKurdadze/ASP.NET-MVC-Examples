using Login_Ajax.Models;
using System.Linq;
using System.Web.Mvc;

namespace Login_Ajax.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public JsonResult Index(string name, string surname)
    {
      MyDbDataContext db = new MyDbDataContext();
      student s = db.students.Where(x => x.Name == name && x.Surname == surname).FirstOrDefault();
      if (s == null)
      {
        return Json("fail", JsonRequestBehavior.AllowGet);
      }
      else
      {
        return Json(true, JsonRequestBehavior.AllowGet);
      }
    }


    public ActionResult About()
    {
      return View();
    }
  }
}