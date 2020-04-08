using CleanBackend.Domain.Entities;
using CleanBackend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanBackend.Infrastructure.Repositories
{
    public class MockItemRepository : IItemRepository
    {
        private List<Item> items { get; set; }

        public MockItemRepository()
        {
            items = new List<Item> {
                new Item("111111", "9901456", "Arla Mellanmjölk 1L", "Swedish milk", "L", 1),
                new Item("222222", "9901456", "Skogaholmslimpa", "Swedish bread", "pcs", 1),
                new Item("333333", "9901456", "Danone Yoghurtkvarg 300ML", "German Kvarg", "L", 1),
                new Item("444444", "9901456", "Kinder Riegel 10 pack", "German choclate", "pcs", 1),
                new Item("555555", "9901456", "Miller Genuine Draft 1 ounce", "American beer", "pcs", 1),
            };
        }

        public Item Get(string id)
        {
            return items.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Item> GetAll()
        {
            return items;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public bool Save()
        {
            return true;
        }
    }
}
