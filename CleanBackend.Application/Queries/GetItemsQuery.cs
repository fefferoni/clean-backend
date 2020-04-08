using CleanBackend.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanBackend.Application.Queries
{
    public class GetItemsQuery : IRequest<IEnumerable<ItemModel>>
    {
        public string TenantId { get; set; }
    }
}
