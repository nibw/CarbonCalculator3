using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("Tbl_Transportation")]
    public class Transportation
    {
        [Key]
        public int TransportationId { get; set; }
        public string TransportationName { get; set; }
    }
}
