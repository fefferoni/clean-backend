using CleanBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanBackend.Domain.Interfaces
{
    public interface IItemRepository
    {
        Item Get(string id);
        IEnumerable<Item> GetAll();
        void AddItem(Item item);
        bool Save();
    }
}
