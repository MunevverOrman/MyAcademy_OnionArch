using MediatR;
using OnionApp.Application.Base;
using OnionApp.Application.Features.Results.CategoryResult;

namespace OnionApp.Application.Features.Queries.CategoryQueries
{
    public class GetCategoriesQuery: IRequest<BaseResult<List<CategoryResults>>>
    {
    }
}
