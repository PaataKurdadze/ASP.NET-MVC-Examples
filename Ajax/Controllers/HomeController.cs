using Ajax.Models;
using System.Linq;
using System.Web.Mvc;

namespace Ajax.Controllers
{
  public class HomeController : Controller
  {
    // GET: Home
    public ActionResult Index()
    {
      MydbDataContext db = new MydbDataContext();

      return View(db.students.ToList());
    }

    [HttpPost]
    public JsonResult Index(string name, string surname, string email, int age)
    {
      student s = new student()
      {
        Name = name,
        Surname = surname,
        Email = email,
        Age = age
      };

      MydbDataContext db = new MydbDataContext();
      db.students.InsertOnSubmit(s);
      db.SubmitChanges();


      return Json(true, JsonRequestBehavior.AllowGet);
    }

  }
}