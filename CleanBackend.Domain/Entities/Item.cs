using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanBackend.Domain.Entities
{
    public class Item : BaseEntity
    {
        /// <summary>
        /// The barcode
        /// </summary>
        [Key]
        public string Id { get; set; }
        /// <summary>
        /// Article number might have several barcodes
        /// </summary>
        public string ItemNo { get; private set; }
        [Required]
        public string Name { get; private set; }
        [Required]
        public string Description { get; private set; }
        public string UnitOfMeasure { get; private set; }
        public double PackageSize { get; private set; }

        public Item(string id, string itemNo, string name, string description, string unitOfMeasure, double packageSize)
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
