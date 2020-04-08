using CleanBackend.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanBackend.Application.Queries
{
    public class GetItemQuery : IRequest<ItemModel>
    {
        public string ItemId { get; set; }
        public string TenantId { get; set; }
    }
}
