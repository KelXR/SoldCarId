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
    
    public partial class AppointmentHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AppointmentHeader()
        {
            this.AppointmentDetails = new HashSet<AppointmentDetail>();
        }
    
        public int AppointmentID { get; set; }
        public int UserID { get; set; }
        public System.DateTime BookingDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppointmentDetail> AppointmentDetails { get; set; }
        public virtual User User { get; set; }
    }
}
