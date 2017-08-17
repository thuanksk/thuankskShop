using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuankskShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID {set; get;  }
        [Key]
        [Column(TypeName="varchar")]
        public int TagID {set; get;  }

        [ForeignKey("ProductID")]
        public virtual Products Products {set;  get; }

        public virtual Tags Tags { set; get; }
    }
}
