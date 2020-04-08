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
    public class GetItemsQueryHandler : IRequestHandler<GetItemsQuery, IEnumerable<ItemModel>>
    {
        private readonly IMapper mapper;
        private readonly IItemRepository itemRepository;

        public GetItemsQueryHandler(IMapper mapper, IItemRepository itemRepository)
        {
            this.mapper = mapper;
            this.itemRepository = itemRepository;
        }
        public Task<IEnumerable<ItemModel>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
        {
            var itemEntities = itemRepository.GetAll();
            var itemModels = mapper.Map<IEnumerable<ItemModel>>(itemEntities);
            return Task.FromResult(itemModels);
        }
    }
}
