//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductTrackingTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblSales
    {
        public int Id { get; set; }
        public int product { get; set; }
        public int customer { get; set; }
        public short piece { get; set; }
        public decimal price { get; set; }
        public decimal total { get; set; }
        public System.DateTime saleDate { get; set; }
    
        public virtual TblCustomer TblCustomer { get; set; }
        public virtual TblProduct TblProduct { get; set; }
    }
}
