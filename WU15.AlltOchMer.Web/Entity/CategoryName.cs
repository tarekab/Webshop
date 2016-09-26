namespace WU15.AlltOchMer.Web.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoryName")]
    public partial class CategoryName
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Category_Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageId { get; set; }

        public int? ParentId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Language Language { get; set; }
    }
}
