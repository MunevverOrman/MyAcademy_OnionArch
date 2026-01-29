using MediatR;
using OnionApp.Application.Base;
using OnionApp.Application.Features.Results.CategoryResult;

namespace OnionApp.Application.Features.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery(int id): IRequest<BaseResult<GetCategoryByIdQueryResult>>
    {
        public int Id { get; set; } = id;
    }
}
