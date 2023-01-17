using System.Linq;
using System.Web.Mvc;
using WebAppMySQLEF.Models;

namespace WebAppMySQLEF.Controllers
{
   public class HomeController : Controller
   {
      public DataAccess DataAccess { get; private set; }
      public HomeController()
      {
         DataAccess = new DataAccess();
      }
      public ActionResult Index()
      {
         var items = DataAccess.Client.ToList();
         return View();
      }

      public ActionResult About()
      {
         ViewBag.Message = "Your application description page.";

         return View();
      }

      public ActionResult Contact()
      {
         ViewBag.Message = "Your contact page.";

         return View();
      }
   }
}