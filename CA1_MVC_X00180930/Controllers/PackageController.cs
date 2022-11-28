using CA1_MVC_X00180930.Models;
using CA1_MVC_X00180930.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CA1_MVC_X00180930.Controllers
{
    public class PackageController : Controller
    { 
     //static List<Package> _packages = new List<Package>()
    
        //new Package{ID=1,ClientName="Bob",ShippingAddress="Newbridge",Weight=2.0,Length=20.0,Width=10.0,Height=40.0 }
     //static list of Package

        // GET: PackageController

        IRepository _repo;

        public PackageController(IRepository repo) //added for repo
        {
            _repo = repo;
            
        }
        public ActionResult Index()
        {
            return View(_repo.AllPackages()); 
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
                    //_packages.Add(p);
                    _repo.CreatePackage(p); //add using repo
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
            var package = _repo.GetPackage(id);
            return View(package);
        }


        // POST: PackageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Package p)
        {
            try
            {
                //var package = _packages.FirstOrDefault(f => f.ID == p.ID);
                //if (package != null)
                //{
                //    package.ClientName = p.ClientName;
                //    package.ShippingAddress = p.ShippingAddress;
                //    package.Weight = p.Weight;
                //    package.Length = p.Length;
                //    package.Width = p.Width;
                //    package.Height = p.Height;
                //}
                _repo.EditPackage(p);// for repo                          
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
