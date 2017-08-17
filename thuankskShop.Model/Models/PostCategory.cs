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
    [Table("PostCategorys")]
    public class PostCategory :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public string Aliias { get; set; }

        public int ?ParentID { get; set; }
        public int MyProperty { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public int ?DisPlayOder { get; set; }
        public string Image { get; set; }
        public int MyProperty { get; set; }
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Post> Posts { set; get; }


    }
}
