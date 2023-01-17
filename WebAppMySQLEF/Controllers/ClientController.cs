using System.Linq;
using System.Web.Mvc;
using WebAppMySQLEF.Models;

namespace WebAppMySQLEF.Controllers
{
   public class ClientController : Controller
   {
      public DataAccess DataAccess { get; private set; }
      public ClientController()
      {
         DataAccess = new DataAccess();
      }

      public ActionResult Index()
      {
         return View(DataAccess.Client.ToList());
      }

      public ActionResult Details(int? id)
      {
         if (id.HasValue)
         {
            var data = DataAccess.Client.Find(id);
            if (data != null)
            {
               return View(data);
            }
         }
         return RedirectToAction("Index");
      }

      public ActionResult Create()
      {
         return View();
      }

      [HttpPost]
      public ActionResult Create(Client client)
      {
         try
         {
            DataAccess.Client.Add(client);
            DataAccess.SaveChanges();
            return RedirectToAction("Index");
         }
         catch
         {
            return View();
         }
      }

      // GET: Client/Edit/5
      public ActionResult Edit(int id)
      {
         var data = DataAccess.Client.Find(id);
         if (data != null)
         {
            return View(data);
         }
         return RedirectToAction("Index");
      }

      // POST: Client/Edit/5
      [HttpPost]
      public ActionResult Edit(Client client)
      {
         try
         {
            DataAccess.Entry(client).State = System.Data.Entity.EntityState.Modified;
            DataAccess.SaveChanges();
            return RedirectToAction("Index");
         }
         catch
         {
            return View();
         }
      }

      // GET: Client/Delete/5
      public ActionResult Delete(int id)
      {
         var data = DataAccess.Client.Find(id);
         if (data != null)
         {
            return View(data);
         }
         return RedirectToAction("Index");
      }

      // POST: Client/Delete/5
      [HttpPost, ActionName("Delete")]
      public ActionResult DeleteConfirmed(int id)
      {
         try
         {
            var data = DataAccess.Client.Find(id);
            if (data != null)
            {
               DataAccess.Client.Remove(data);
               DataAccess.SaveChanges();
               return RedirectToAction("Index");
            }
            return View();
         }
         catch
         {
            return View();
         }
      }
   }
}
