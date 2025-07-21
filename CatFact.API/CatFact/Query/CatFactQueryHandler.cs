using CatFact.API.IRepository;
using MediatR;

namespace CatFact.API.CatFact.Query
{
    public class CatFactQueryHandler(ILogger<CatFactQueryHandler> logger,
        ICatFactRepository catFactRepository) : IRequestHandler<CatFactQuery, CatFacts>
    {
        public async Task<CatFacts> Handle(CatFactQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Getting fact about cats");
            var catFact = await catFactRepository.GetFactFromWebAsync();
           

            return catFact;
        }
    }
}
