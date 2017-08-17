﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thuankskShop.Model.Abstracst;

namespace thuankskShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategorys { set; get; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public int ALiias { get; set; }
        [MaxLength]
        public string Content { get; set; }
        public string Description { get; set; }
         [MaxLength(256)]
        public string Image { get; set; }
         [MaxLength(256)]
        public bool? HomeFlag { get; set; }
        public int? ViewCount { get; set; }
        public bool? HotFlag { get; set; }



    }
}
