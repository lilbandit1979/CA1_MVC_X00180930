using CA1_MVC_X00180930.Models;

namespace CA1_MVC_X00180930.Repository
{
    public class MockDB : IRepository
 {       
        static List<Package> _packages = new List<Package>();// packages list
    
        public List<Package> AllPackages()
        {
            return _packages;
        }

        public void CreatePackage(Package package)
        {
            _packages.Add(package);
        }

        public void EditPackage(Package p)
        {
            var package = _packages.FirstOrDefault(x => x.ID == p.ID);
            if (package != null)
            {
                package.ClientName = p.ClientName;
                package.ShippingAddress = p.ShippingAddress;
                package.Weight = p.Weight;
                package.Length = p.Length;
                package.Width = p.Width;
                package.Height = p.Height;
            }
        }

        public Package GetPackage(int id)
        {
            var package = _packages.FirstOrDefault(x => x.ID == id);
            if(package!=null)
            {
                return package;
            }
            throw new ArgumentException("Error: package cannot be null");

        }
    }
}
