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

        public async Task SaveCatFactTotxtFile(CatFacts catFacts)
        {
            var information = $"{catFacts.Fact} : Length of fact about cats {catFacts.Length}";
            await File.AppendAllTextAsync(WebCatFactsCounstants.filePath, information + Environment.NewLine);
        }
    }
}
