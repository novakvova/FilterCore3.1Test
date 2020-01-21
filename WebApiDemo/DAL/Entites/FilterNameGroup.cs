﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.DAL.Entites
{
    [Table("tblFilterNameGroups")]
    public class FilterNameGroup
    {
        [ForeignKey("FilterNameOf"), Key, Column(Order = 0)]
        public long FilterNameId { get; set; }
        public virtual FilterName FilterNameOf { get; set; }

        [ForeignKey("FilterValueOf"), Key, Column(Order = 1)]
        public long FilterValueId { get; set; }
        public virtual FilterValue FilterValueOf { get; set; }
    }
}
