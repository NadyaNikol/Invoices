using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    public class User
    {
        [Key]
        public int Id { set; get; }

        [Required]
        [MaxLength(50)]
        public string Surname { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(50)]
        public string Patronymic { set; get; }

        
        public int SexId { get; set; }
        
        public virtual List<Invoice> Invoices { set; get; }
        [ForeignKey("SexId")]
        public virtual Sex Sexes { set; get; }
    }
}
