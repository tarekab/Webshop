namespace WU15.AlltOchMer.Web.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subcategories
    {
        public int? Categoryid { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Category_Id { get; set; }

        [StringLength(50)]
        public string MainCategory { get; set; }

        public int? Id { get; set; }
    }
}
