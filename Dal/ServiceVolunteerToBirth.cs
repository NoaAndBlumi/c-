//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceVolunteerToBirth
    {
        public long ServiceId { get; set; }
        public long VolunteerId { get; set; }
        public long MotherId { get; set; }
        public long BirthId { get; set; }
        public System.DateTime DateItWas { get; set; }
        public Nullable<System.TimeSpan> BeginningTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
    
        public virtual ServiceManagementToBirth ServiceManagementToBirth { get; set; }
    }
}
