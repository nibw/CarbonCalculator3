using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("Tbl_Periode")]
    public class Periode
    {
        [Key]
        public int PeriodeId { get; set; }
        public int UserId { get; set; }
        public DateTime Month { get; set; }
        public DateTime Year { get; set; }
    }
}
