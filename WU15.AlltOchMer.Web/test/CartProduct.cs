//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WU15.AlltOchMer.Web.test
{
    using System;
    using System.Collections.Generic;
    
    public partial class CartProduct
    {
        public int Id { get; set; }
        public System.Guid CartGuid { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Pris { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
