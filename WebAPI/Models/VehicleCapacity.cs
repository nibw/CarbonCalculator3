using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("Tbl_VehicleCapacity")]
    public class VehicleCapacity
    {
        [Key]
        public int CapacityId { get; set; }

        [Required]
        [ForeignKey("Tbl_VehicleType")]
        public int VehicleId { get; set; }
        public virtual VehicleType VehicleTypes { get; set; }

        [Required]
        [ForeignKey("Tbl_Fuel")]
        public int FuelId { get; set; }
        public virtual Fuel Fuels { get; set; }

        [Required]
        [ForeignKey("Tbl_Transportation")]
        public int TransportationId { get; set; }
        public virtual Transportation Transportations { get; set; }

        [Required]
        public int CubicalCentimeter { get; set; }

        [MaxLength(200)]
        public string? Formula { get; set; }
    }
}
