using CodeFirst.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model.Entities.Concrete
{
    public class Shipper : BaseEntity<int>
    {
        public override int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string CompanyName { get; set; }
        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }
    }
}
