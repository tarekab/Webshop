namespace WU15.AlltOchMer.Web.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainCategorySweden")]
    public partial class MainCategorySweden
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(150)]
        public string ProductName { get; set; }

        public DateTime? PriceListName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Category_Id { get; set; }

        public decimal? Price { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageId { get; set; }

        [StringLength(3)]
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(2500)]
        public string Description { get; set; }

        public decimal? VAT { get; set; }

        [StringLength(50)]
        public string ArticleNumber { get; set; }
    }
}
