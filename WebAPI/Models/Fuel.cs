using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("Tbl_Fuel")]
    public class Fuel
    {
        [Key]
        public int FuelId { get; set; }
        public string FuelName { get; set; }
    }
}
