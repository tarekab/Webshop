namespace WU15.AlltOchMer.Web.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
