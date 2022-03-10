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
    public class Order : BaseEntity<int>
    {
        public override int Id { get; set; }

        [ForeignKey("Customer")]
        public string CustomerId { get; set; }      
        public virtual Customer Customer { get; set; }
        
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }   
        
        public DateTime? ShippedDate { get; set; }
        
        [ForeignKey("Shipper")]
        [Column("ShipVia")]
        public int ShipperId { get; set; }

        public virtual Shipper Shipper { get; set; }
        
        public int? Weight { get; set; }

        [Required]
        [MaxLength(40)]
        public string ShipName { get; set; }

        [Required]
        [MaxLength(100)]
        public string ShipAdress { get; set; }

        [Required]
        [MaxLength(20)]
        public string ShipCity { get; set; }

        [Required]
        [MaxLength(20)]
        public string ShipCountry { get; set; }


    }
}
