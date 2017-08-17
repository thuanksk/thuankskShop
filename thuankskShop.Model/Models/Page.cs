using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thuankskShop.Model.Abstracst;

namespace thuankskShop.Model.Models
{
    [Table("Page")]
    public class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName="varchar")]
        public string Name { get; set; }

        public string content { get; set; }
        [Required]
        public string Aliias { get; set; }

    }
}
