using System;
using System.Collections.Generic;
using System.Text;

namespace CleanBackend.Application.Models
{
    public class ItemModel
    {
        public string Id { get; set; }
        public string ItemNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasure { get; set; }
        public double PackageSize { get; set; }
    }
}
