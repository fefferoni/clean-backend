using AutoMapper;
using CleanBackend.Application.Commands;
using CleanBackend.Application.Models;
using CleanBackend.Domain.Entities;
using CleanBackend.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanBackend.Application.Handlers
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, ItemModel>
    {
        private readonly IMapper mapper;
        private readonly IItemRepository itemRepository;

        public CreateItemCommandHandler(IMapper mapper, IItemRepository itemRepository)
        {
            this.mapper = mapper;
            this.itemRepository = itemRepository;
        }

        public Task<ItemModel> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var itemEntity = mapper.Map<Item>(request);

            itemRepository.AddItem(itemEntity);

            if (!itemRepository.Save())
            {
                throw new Exception("Creating an item failed on save.");
            }

            var itemToReturn = mapper.Map<ItemModel>(itemEntity);

            return Task.FromResult(itemToReturn);
        }
    }
}
