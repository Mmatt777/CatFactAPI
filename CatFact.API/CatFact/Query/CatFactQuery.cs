using MediatR;

namespace CatFact.API.CatFact.Query
{
    public record class CatFactQuery() : IRequest<CatFacts>
    {
    }
}
