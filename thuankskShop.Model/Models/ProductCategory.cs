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
    [Table("ProductCategorys")]
   public class ProductCategory:Auditable
    {
       [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int? ParentID { get; set; }
        public int?  DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool HomeFlag { get; set; }

        public virtual IEnumerable<Products> Productss { get; set; }
   
   }
}
