//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orders_Placing.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goods_Received_Note
    {
        public string goodReceivedId { get; set; }
        public Nullable<System.DateTime> importDate { get; set; }
        public string accountantName { get; set; }
        public Nullable<double> totalPrice { get; set; }
    
        public virtual Accountant Accountant { get; set; }
    }
}