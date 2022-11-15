using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("Tbl_CarbonType")]
    public class CarbonType
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
