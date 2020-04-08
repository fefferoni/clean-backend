using CleanBackend.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CleanBackend.Application.Commands
{
    public class CreateItemCommand : IRequest<ItemModel>
    {
        // Todo: make this model immutable (have tried but the properties never get set)

        public string Id { get; set; }
        public string ItemNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasure { get; set; }
        public double PackageSize { get; set; }

        public CreateItemCommand()
        {

        }

        public CreateItemCommand(string id, string itemNo, string name, string description, string unitOfMeasure, double packageSize)
        {
            Id = id;
            ItemNo = itemNo;
            Name = name;
            Description = description;
            UnitOfMeasure = unitOfMeasure;
            PackageSize = packageSize;
        }
    }
}
