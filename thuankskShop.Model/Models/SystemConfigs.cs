﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuankskShop.Model.Models
{
    [Table("SystemConfigss")]
    public class SystemConfigs
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(50)]
        public string ValueString { get; set; }
        public int? ValueInt { get; set; }

    }
}
