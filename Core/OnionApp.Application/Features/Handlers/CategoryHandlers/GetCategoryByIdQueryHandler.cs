using Mapster;
using MediatR;
using OnionApp.Application.Base;
using OnionApp.Application.Contracts;
using OnionApp.Application.Features.Queries.CategoryQueries;
using OnionApp.Application.Features.Results.CategoryResult;
using OnionApp.Domain.Entities;

namespace OnionApp.Application.Features.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler(IRepositoy<Category> _repositoy) : IRequestHandler<GetCategoryByIdQuery, BaseResult<GetCategoryByIdQueryResult>>
    {
        public async Task<BaseResult<GetCategoryByIdQueryResult>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _repositoy.GetByIdAsync(request.Id);
            if (category is null)
            {
                return BaseResult<GetCategoryByIdQueryResult>.Fail("Kategori bulunamadı");
            }

            var mappedCategory=category.Adapt<GetCategoryByIdQueryResult>();

            return BaseResult<GetCategoryByIdQueryResult>.Success(mappedCategory);
        }
    }
}
