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
    public class Customer:BaseEntity<string>
    {
        public override string Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; }

        [MaxLength(30)]
        public string ContactName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Address { get; set; }

        [Required]
        [MaxLength(20)]
        public string City { get; set; }

        [Required]
        [MaxLength(20)]
        public string Country { get; set; }

        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }

        public string Fax { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
