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
    
    public partial class Feeedback
    {
        public int feedbackId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public System.DateTime timestamp { get; set; }
        public Nullable<int> volunteerId { get; set; }
        public Nullable<int> patientId { get; set; }
        public string feedback { get; set; }
        public int deptId { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}