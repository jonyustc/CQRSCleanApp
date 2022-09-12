using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;

namespace Application.Features.Products
{
    public class ProductCreate
    {
        public class Command : IRequest
        {
            public CreateProductDto Product { get; set; }
        }

        public class ProductCreateValidator : AbstractValidator<Command>
        {
            public ProductCreateValidator()
            {
                RuleFor(x=>x.Product).SetValidator(new ProductCommandValidator());
            }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IRepositoryBase<Product> _productRepo;
            private readonly IMapper _mapper;

            public Handler(IRepositoryBase<Product> productRepo,IMapper mapper)
            {
                _productRepo = productRepo;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var product = _mapper.Map<Product>(request.Product);


                _productRepo.Add(product);

                await _productRepo.CompleteAsync();
                

                return Unit.Value;
            }
        }
    }
}