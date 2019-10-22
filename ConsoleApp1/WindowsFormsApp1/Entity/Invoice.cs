using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    public class Invoice
    {
        [Key]
        public int Id { set; get; }

        [Required]
        public int? UserId { set; get; }

        [Required]
        public DateTime Date { set; get; }

        [Required]
        public double Sum { set; get; }

        [ForeignKey("UserId")]
        public User User{ set; get; }
    }
}
