using CatFact.API.CatFact;

namespace CatFact.API.IRepository
{
    public interface ICatFactRepository
    {
        Task<CatFacts> GetFactFromWebAsync();
    }
}
