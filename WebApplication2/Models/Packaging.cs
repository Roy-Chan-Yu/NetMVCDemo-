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
    
    public partial class Packaging
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Packaging()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public string Packag_Type { get; set; }
        public Nullable<int> Paper_Color_ID { get; set; }
        public Nullable<int> String_Color_ID { get; set; }
        public string Design { get; set; }
        public string Package_Description { get; set; }
        public string Card { get; set; }
    
        public virtual Colour Colour { get; set; }
        public virtual Colour Colour1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
