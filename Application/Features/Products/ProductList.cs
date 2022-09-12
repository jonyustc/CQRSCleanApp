using Application.Interfaces;
using Domain;
using MediatR;

namespace Application.Features.Products
{
    public class ProductList
    {
        public class Query : IRequest<IReadOnlyList<Product>>
        {

        }

        public class Handler : IRequestHandler<Query,IReadOnlyList<Product>>
        {
            private readonly IRepositoryBase<Product> _productRepo;

            public Handler(IRepositoryBase<Product> productRepo)
            {
                _productRepo = productRepo;
            }

            public async Task<IReadOnlyList<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _productRepo.GetListAsync();
            }
        }
    }
}