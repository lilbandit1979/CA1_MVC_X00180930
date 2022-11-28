using CA1_MVC_X00180930.Models;

namespace CA1_MVC_X00180930.Repository
{
    public interface IRepository
    {
        List<Package> AllPackages();
        Package GetPackage(int id);
        void CreatePackage(Package package);
        void EditPackage(Package package);
    }
}
