using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSystem.Models
{
    public class Household
    {
        [Key]
        public int HouseholdId { get; set; }

        [DisplayName("Jumlah orang dalam rumah")]
        [Required(ErrorMessage = "Wajib di isi")]
        [Range(1,9999, ErrorMessage ="Minimal angka adalah 1")]
        public int AmountPeople { get; set; }

        [DisplayName("Standmeter listrik bulan ini")]
        [Required(ErrorMessage = "Wajib di isi")]
        [Range(1, 9999, ErrorMessage = "Minimal angka adalah 1")]
        public int Standmeter { get; set; }

        [DisplayName("Konsumsi gas LPG bulan ini (KG)")]
        [Required(ErrorMessage = "Wajib di isi")]
        [Range(1, 9999, ErrorMessage = "Minimal angka adalah 1")]
        public int LpgConsumption { get; set; }

        [DisplayName("Standmeter listrik bulan ini (kWh)")]
        [Required(ErrorMessage = "Wajib di isi")]
        [Range(1, 9999, ErrorMessage = "Minimal angka adalah 1")]
        public int CityGasConsumption { get; set; }

        //[DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        public int KonsumsiListrik()
        {
            var konsumsilistrik = Standmeter + 1;
            return konsumsilistrik;
        }

        public int KonsumsiGas()
        {
            var konsumsigas = CityGasConsumption + 1;
            return konsumsigas;
        }

        public int EmisiCo2Listrik()
        {
            var emisicolistrik = AmountPeople + Standmeter;
            return emisicolistrik;
        }

        public int EmisiCo2Gas()
        {
            var emisicogas = AmountPeople + LpgConsumption + CityGasConsumption;
            return emisicogas;
        }

        public int EmisiCo2Person()
        {
            var emisicoperson = AmountPeople + Standmeter + LpgConsumption + CityGasConsumption;
            return emisicoperson;
        }
    }
}
