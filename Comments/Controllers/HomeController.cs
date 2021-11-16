using Comments.Models;
using System.Linq;
using System.Web.Mvc;

namespace Comments.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      MydbDataContext db = new MydbDataContext();

      return View(db.comments.ToList().OrderByDescending(x => x.ID));
    }

    public JsonResult Add(string text)
    {
      MydbDataContext db = new MydbDataContext();

      comment c = new comment();
      c.Comment1 = text;

      db.comments.InsertOnSubmit(c);
      db.SubmitChanges();

      return Json(true, JsonRequestBehavior.AllowGet);
    }
  }
}