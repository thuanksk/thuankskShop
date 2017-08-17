using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuankskShop.Model.Models
{
    [Table("Tagss")]
    public class Tags
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
        public virtual IEnumerable<PossTag> Postags { set; get; }

    }
}
