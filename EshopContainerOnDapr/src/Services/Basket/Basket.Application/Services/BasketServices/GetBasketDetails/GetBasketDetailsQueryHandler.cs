using Basket.Abstraction.Dtos;
using EshopContainerOnDapr.Abstractions.Model;
using EshopContainerOnDapr.Dapr.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.Services.BasketServices.GetBasketDetails
{
    public class GetBasketDetailsQueryHandler : IRequestHandler<GetBasketDetailsQuery, Result<BasketDto>>
    {
        private readonly IDaprStateStore _daprStateStore;
        public GetBasketDetailsQueryHandler(IDaprStateStore daprStateStore)
        {
            _daprStateStore = daprStateStore;
        }
        private const string STATE_STORE_NAME = "statestore";
        public async Task<Result<BasketDto>> Handle(GetBasketDetailsQuery request, CancellationToken cancellationToken)
        {

            return new SuccessResult<BasketDto>(
                await _daprStateStore.GetStateAsync<BasketDto>(STATE_STORE_NAME, request.CustomerId))
            {
                Messages = new List<string>
                    {
                        "Ürün sepete kaydedildi"
                    }
            };
        }
    }
}
