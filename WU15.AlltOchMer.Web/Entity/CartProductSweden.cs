namespace WU15.AlltOchMer.Web.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CartProductSweden")]
    public partial class CartProductSweden
    {
        [Key]
        [Column(Order = 0)]
        public Guid Guid { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CreationDate { get; set; }

        public decimal? Pris { get; set; }

        public int? Quantity { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid CartGuid { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}
