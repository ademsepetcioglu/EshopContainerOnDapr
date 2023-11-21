using Basket.Abstraction.Dtos;
using EshopContainerOnDapr.Abstractions.Model;
using EshopContainerOnDapr.Dapr.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.Services.BasketServices.UpdateBasketDetails
{
    public class UpdateBasketCommandHandler : IRequestHandler<UpdateBasketCommand, Result<BasketDto>>
    {
        private readonly IDaprStateStore _stateStore;
        public UpdateBasketCommandHandler(IDaprStateStore stateStore)
        {
            _stateStore = stateStore;
        }
        private const string DAPR_STATESTORE_NAME = "statestore";
        public async Task<Result<BasketDto>> Handle(UpdateBasketCommand request, CancellationToken cancellationToken)
        {
            await _stateStore.UpdateStateAsync<UpdateBasketCommand>(DAPR_STATESTORE_NAME, request.BuyerId, request);

            return new SuccessResult<BasketDto>(await _stateStore.GetStateAsync<BasketDto>(DAPR_STATESTORE_NAME, request.BuyerId))
            {
                Messages = new List<string>
                    {
                        "Ürün checkout işlemi order servise günderildi"
                    }
            };
        }
    }
}
