using Application.Dtos;
using Domain;
using FluentValidation;

namespace Application.Features.Products
{
    public class ProductCommandValidator : AbstractValidator<CreateProductDto>
    {
        public ProductCommandValidator()
        {
            RuleFor(x=>x.ProductCode).NotEmpty();
            RuleFor(x=>x.ProductName).NotEmpty();
            RuleFor(x=>x.ProductCategoryId).NotEmpty();
            RuleFor(x=>x.ProductUnitId).NotEmpty();
        }
    }
}