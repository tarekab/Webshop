namespace WU15.AlltOchMer.Web.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSe")]
    public partial class ProductSe
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(150)]
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        [StringLength(2500)]
        public string Description { get; set; }

        [StringLength(50)]
        public string ArticleNumber { get; set; }

        public decimal? Price { get; set; }
    }
}
