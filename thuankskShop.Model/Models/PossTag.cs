﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuankskShop.Model.Models
{
    [Table("PostTags")]
    public class PossTag
    {

        [Key]
        public int PostID { get; set; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("TagID")]
        public virtual Tags Tagss { set; get; }
        [ForeignKey("PostID")]
        public virtual Post post { set; get; }
    }
}
