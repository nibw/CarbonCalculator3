using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("TblT_VehicleEmision")]
    public class VehicleEmision
    {
        [Key]
        public int VehicleEmisionId { get; set; }
        
        [ForeignKey("Tbl_VehicleType")]
        public int VehicleId { get; set; }
        public virtual VehicleType VehicleTypes { get; set; }

        [ForeignKey("Tbl_Fuel")]
        public int FuelId { get; set; }
        public virtual Fuel Fuels { get; set; }

        [ForeignKey("Tbl_Transportation")]
        public int TransportationId { get; set; }
        public virtual Transportation Transportations { get; set; }

        [ForeignKey("Tbl_VehicleCapacity")]
        public int CapacityId { get; set; }
        public virtual VehicleCapacity VehicleCapacities { get; set; }

        [ForeignKey("Tbl_Transportation")]
        public int PeriodeId { get; set; }
        public virtual Periode Periodes { get; set; }
        public int? UserId { get; set; }
        public int TravelFrequency { get; set; }
        public DateTime Per { get; set; }
        public int AmountPeople { get; set; }
        public decimal Mileage { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
