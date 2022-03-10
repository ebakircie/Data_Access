using CodeFirst.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model.Entities.Concrete
{
    public class Product : BaseEntity<int>
    {
        public override int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string ProductName { get; set; }
        [Required]
        public int QuantityPerUnit { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; } 
        public virtual Category Category { get; set; }

    }
}
