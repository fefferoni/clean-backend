using AutoMapper;
using CleanBackend.Application.Models;
using CleanBackend.Application.Queries;
using CleanBackend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanBackend.Application.Handlers
{
    public class GetItemQueryHandler : IRequestHandler<GetItemQuery, ItemModel>
    {
        private readonly IMapper mapper;
        private readonly IItemRepository itemRepository;

        public GetItemQueryHandler(IMapper mapper, IItemRepository itemRepository)
        {
            this.mapper = mapper;
            this.itemRepository = itemRepository;
        }
        public Task<ItemModel> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {
            var item = itemRepository.Get(request.ItemId);

            return Task.FromResult(item == null ? null : mapper.Map<ItemModel>(item));
        }
    }
}
