using CodeFirst.Model.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Model.Entities.Concrete
{
    public class Category:BaseEntity<int>
    {

        public override int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
