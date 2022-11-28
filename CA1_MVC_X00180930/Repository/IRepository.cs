using CA1_MVC_X00180930.Models;

namespace CA1_MVC_X00180930.Repository
{
    public interface IRepository
    {
        List<Package> AllFixtures();
        Package GetPackage(int id);
        void Create(Package package);
        void EditFixture(Package package);
    }
}
