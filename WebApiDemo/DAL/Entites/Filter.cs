﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.DAL.Entites
{
    [Table("tblFilters")]
    public class Filter
    {
        [ForeignKey("FilterNameOf"), Key, Column(Order = 0)]
        public long FilterNameId { get; set; }
        public virtual FilterName FilterNameOf { get; set; }

        [ForeignKey("FilterValueOf"), Key, Column(Order = 1)]
        public long FilterValueId { get; set; }
        public virtual FilterValue FilterValueOf { get; set; }

        [ForeignKey("ProductOf"), Key, Column(Order = 2)]
        public long ProductId { get; set; }
        public virtual Product ProductOf { get; set; }
    }
}
