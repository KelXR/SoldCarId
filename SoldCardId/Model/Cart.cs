//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoldCardId.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int UserID { get; set; }
        public int CarID { get; set; }
        public string Location { get; set; }
        public System.DateTime AppointmentDate { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}
