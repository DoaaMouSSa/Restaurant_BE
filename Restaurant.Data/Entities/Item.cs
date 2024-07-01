using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        [ForeignKey("CategoryId")]
        [InverseProperty("Items")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
