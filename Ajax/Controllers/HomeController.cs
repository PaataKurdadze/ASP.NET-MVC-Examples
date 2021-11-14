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
    public JsonResult Index(string name, string surname, int age, string email)
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

      int id = db.students.OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault();

      return Json(id, JsonRequestBehavior.AllowGet);
    }

    [HttpPost]
    public JsonResult Delete(int id)
    {
      MydbDataContext db = new MydbDataContext();

      db.students.DeleteOnSubmit(db.students.Where(x => x.Id == id).FirstOrDefault());
      db.SubmitChanges();

      return Json(true, JsonRequestBehavior.AllowGet);
    }


  }
}