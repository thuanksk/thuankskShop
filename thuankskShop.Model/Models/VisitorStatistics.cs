using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuankskShop.Model.Models
{
    [Table("VisitorStatisticss")]
    public class VisitorStatistics
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public DateTime VisitDate { get; set; }
        [Required]
        public string IPAdress { get; set; }
    }
}
