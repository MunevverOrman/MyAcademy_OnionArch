using OnionApp.Application.Features.Results.CategoryResult;

namespace OnionApp.Application.Features.Results.ProductResults
{
    public class GetProductByIdQueryResult
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public CategoryResults Category { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
