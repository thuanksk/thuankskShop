using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuankskShop.Model.Models
{
    [Table("Oderss")]
    public class Oders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerNameADress { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerNameEmail { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerNameMobile { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerNameMessege { get; set; }
        [MaxLength(256)]
        public string PaymentMethod { get; set; }

        public string CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string PaymentSatus { get; set; }
        public bool Status { get; set; }
        public virtual IEnumerable<OderDetails> OderDetailss { set; get; }

    }
}
