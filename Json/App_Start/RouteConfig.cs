using System.Web.Mvc;
using System.Web.Routing;

namespace Json
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
      // RouteConfig -ში name დავამატეთ
      // თუ RouteConfig-ში არ შევცვლიდით მაშინ ასე შეგვეძლო არგუმენტების გადაცემა /Home/index/?id=1&name=Paata
      routes.MapRoute(
          name: "Default",
          url: "{controller}/{action}/{id}/{name}",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional }
      );


      //შეიძლება სხვა როუტინგიც დავწეროთ პარალელურად
      routes.MapRoute(
         name: "Default2",
         url: "{controller}/{action}/{id}/{name}",
         defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, name = "Paata" }
     );
    }


  }
}
