using System;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace ShopBridge.Model
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public bool IsStatus { get; set; } = true;
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
