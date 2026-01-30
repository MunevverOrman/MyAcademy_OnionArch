using OnionApp.Application.Features.Results.ProductResults;

namespace OnionApp.Application.Features.Results.CategoryResult
{
    public class CategoryResult
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<GetProductsQueryResult> Products { get; set; }
    }
}
