namespace DemoOOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string Manufacture { get; set; }

        public DateTime? CreatedAt { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? UpdateAt { get; set; }

        [StringLength(50)]
        public string UpdateBy { get; set; }

        public bool? Deleted { get; set; }

        public bool? Active { get; set; }
    }
}
