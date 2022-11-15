using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("Tbl_VehicleType")]
    public class VehicleType
    {
        [Key]
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
    }
}
