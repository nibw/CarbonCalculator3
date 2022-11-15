using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("TblT_Household")]
    public class Household
    {
        [Key]
        public int HouseholdId { get; set; }

        [DisplayName("Jumlah orang dalam rumah")]
        [Required(ErrorMessage = "Wajib di isi")]
        public int AmountPeople { get; set; }

        [DisplayName("Standmeter listrik bulan ini")]
        [Required(ErrorMessage = "Wajib di isi")]
        public int Standmeter { get; set; }

        [DisplayName("Konsumsi gas LPG bulan ini (KG)")]
        [Required(ErrorMessage = "Wajib di isi")]
        public int LpgConsumption { get; set; }

        [DisplayName("Standmeter listrik bulan ini (kWh)")]
        [Required(ErrorMessage = "Wajib di isi")]
        public int CityGasConsumption { get; set; }

        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime CreatedDate { get; set; }
        //public int? ElectricityCons { get; set; }
        //public int? GasCons { get; set; }
        //public int? ElectricityEmision { get; set; }
        //public int? GasEmision { get; set; }
        //public int? PeopleEmision { get; set; }

        //public int KonsumsiListrik()
        //{
        //    var konsumsilistrik = Standmeter + 1;
        //    return konsumsilistrik;
        //}

        //public int KonsumsiGas()
        //{
        //    var konsumsigas = CityGasConsumption + 1;
        //    return konsumsigas;
        //}

        //public int EmisiCo2Listrik()
        //{
        //    var emisicolistrik = AmountPeople + Standmeter;
        //    return emisicolistrik;
        //}

        //public int EmisiCo2Gas()
        //{
        //    var emisicogas = AmountPeople + LpgConsumption + CityGasConsumption;
        //    return emisicogas;
        //}

        //public int EmisiCo2Person()
        //{
        //    var emisicoperson = AmountPeople + Standmeter + LpgConsumption + CityGasConsumption;
        //    return emisicoperson;
        //}
    }
}
