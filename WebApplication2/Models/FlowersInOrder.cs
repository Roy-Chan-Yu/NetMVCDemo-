//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlowersInOrder
    {
        public int Order_ID { get; set; }
        public int Flower_ID { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> Price { get; set; }
    
        public virtual Flower Flower { get; set; }
    }
}
