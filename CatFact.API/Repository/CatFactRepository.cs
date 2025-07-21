using CatFact.API.CatFact;
using CatFact.API.Constants;
using CatFact.API.IRepository;

namespace CatFact.API.Repository
{
    public class CatFactRepository(HttpClient httpClient) : ICatFactRepository
    {      
        public async Task<CatFacts> GetFactFromWebAsync()
        {
            var fact = await httpClient.GetFromJsonAsync<CatFacts>(WebCatFactsCounstants.CatFactSource);
            return fact!;
        }
    }
}
