using MeriatRFinal3.Models;
using MeriatRFinal3.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MeriatRFinal3.Features.ProductFeatures.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string SellerName { get; set; }
        public string Country { get; set; }
        public decimal Rate { get; set; }
        public decimal BuyingPrice { get; set; }
        public string BrandName { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            private readonly IApplicationContext _context;
            public CreateProductCommandHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(CreateProductCommand command, CancellationToken cancellationToken)
            {
                var product = new Product();
                product.Name = command.Name;
                product.SellerName = command.SellerName;
                product.Country = command.Country;
                product.Rate = command.Rate;
                product.BuyingPrice = command.BuyingPrice;
                product.BrandName = command.BrandName;

                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return product.Id;
            }
        }
    }
}
