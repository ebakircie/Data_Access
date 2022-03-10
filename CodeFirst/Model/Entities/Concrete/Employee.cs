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
    public class Employee : BaseEntity<int>
    {
        public override int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }

        public DateTime? BirthDate { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [MaxLength(100)]
        public string Adress { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(20)]
        public string Country { get; set; }

        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }





    }
}
