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
    
    public partial class user_info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_info()
        {
            this.consignee_manageme = new HashSet<consignee_manageme>();
        }
    
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_sex { get; set; }
        public string user_phone { get; set; }
        public string user_pw { get; set; }
        public string user_state { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consignee_manageme> consignee_manageme { get; set; }
    }
}
