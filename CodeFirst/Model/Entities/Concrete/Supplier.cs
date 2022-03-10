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
    
    public class Supplier : BaseEntity<int>
    {
        public override int Id { get; set; }

        [Required]
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        [Required]
        public int Phone { get; set; }

        [Required]
        [MaxLength(60)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(15)]
        public string City { get; set; }
        [Required]
        [MaxLength(15)]
        public string Country { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
