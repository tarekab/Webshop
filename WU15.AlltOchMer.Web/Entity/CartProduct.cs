namespace WU15.AlltOchMer.Web.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CartProduct")]
    public partial class CartProduct
    {
        public int Id { get; set; }

        public Guid CartGuid { get; set; }

        public int ProductId { get; set; }

        public int? Quantity { get; set; }

        public decimal? Pris { get; set; }

        public virtual Product Product { get; set; }
    }
}
