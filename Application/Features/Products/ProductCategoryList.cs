using Application.Interfaces;
using Domain;
using MediatR;

namespace Application.Features.Products
{
    public class ProductCategoryList 
    {
        public  class Query : IRequest<IReadOnlyList<ProductCategory>>
        {

        }

        public class Handler : IRequestHandler<Query, IReadOnlyList<ProductCategory>>
        {
            private readonly IRepositoryBase<ProductCategory> _productCategoryRepo;

            public Handler(IRepositoryBase<ProductCategory> productCategoryRepo)
            {
                _productCategoryRepo = productCategoryRepo;
            }

            public async Task<IReadOnlyList<ProductCategory>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _productCategoryRepo.GetListAsync();
            }
        }
    }
}