using Application.Dtos;
using Application.Features.Products;
using AutoMapper.Features;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _mediator.Send(new ProductList.Query()));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto product)
        {
            var result = await _mediator.Send(new ProductCreate.Command{ Product = product});

            return Ok(result);
        }

        [HttpGet("ProductCategories")]
        public async Task<IActionResult> GetProductCategories()
        {
            return Ok(await _mediator.Send(new ProductCategoryList.Query()));
        }
    }
}