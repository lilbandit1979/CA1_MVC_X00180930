using CA1_MVC_X00180930.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CA1_MVC_X00180930.Controllers
{
    public class PackageController : Controller
    { 
    public static List<Package> _packages = new List<Package>()
    {
        //new Package{ID=1,ClientName="Bob",ShippingAddress="Newbridge",Weight=2.0,Length=20.0,Width=10.0,Height=40.0 }
    }; //static list of Package
    
        // GET: PackageController
        public ActionResult Index()
        {
            return View(_packages); //repo not set up yet
        }

        // GET: PackageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PackageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PackageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Package p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _packages.Add(p);
                    //_repo.Create(f);
                    return RedirectToAction(nameof(Index));
                }
                return View(p);
            }

            catch
            {
                return View();
            }
        }

        // GET: PackageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PackageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PackageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PackageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
