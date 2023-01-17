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

      public ActionResult Details(int id)
      {
         return View();
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
            // TODO: Add insert logic here
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
         return View();
      }

      // POST: Client/Edit/5
      [HttpPost]
      public ActionResult Edit(int id, FormCollection collection)
      {
         try
         {
            // TODO: Add update logic here

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
         return View();
      }

      // POST: Client/Delete/5
      [HttpPost]
      public ActionResult Delete(int id, FormCollection collection)
      {
         try
         {
            // TODO: Add delete logic here

            return RedirectToAction("Index");
         }
         catch
         {
            return View();
         }
      }
   }
}
