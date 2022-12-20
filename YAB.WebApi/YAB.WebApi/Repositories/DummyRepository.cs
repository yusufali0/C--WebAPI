using YAB.WebApi.Interfaces;

namespace YAB.WebApi.Repositories
{
    public class DummyRepository : IDummyRepository
    {
        public string GetName()
        {
            return "Yusuf Ali";
        }
    }
}
