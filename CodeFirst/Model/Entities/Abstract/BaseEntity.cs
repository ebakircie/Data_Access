using CodeFirst.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model.Entities.Abstract
{
    public abstract class BaseEntity <T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public abstract T Id { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate
        {
            get => _createDate;
            set => _createDate = value;
        }
       
        public DateTime? UpdateDate { get; set; }
       
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status
        {
            get => _status;
            set => _status = value;
        }
    }
}
