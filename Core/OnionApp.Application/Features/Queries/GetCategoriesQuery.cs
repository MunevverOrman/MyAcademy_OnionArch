using MediatR;
using OnionApp.Application.Base;
using OnionApp.Application.Features.Results.CategoryResult;

namespace OnionApp.Application.Features.Queries
{
    public class GetCategoriesQuery: IRequest<BaseResult<List<GetCategoriesQueryResult>>>
    {
    }
}
