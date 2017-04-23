//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetaByte_KellysFeatures2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int id { get; set; }
        public string Status { get; set; }
        public string PurposeOfVisit { get; set; }
        public string HealthCardNum { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public int PatientId { get; set; }
        public string PhysicianName { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime DateofAppointment { get; set; }
        public System.DateTime PreferredAppTime { get; set; }
        public System.DateTime PreferredDate { get; set; }
        public System.DateTime DateofRequest { get; set; }
        public System.DateTime DateApproved { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
