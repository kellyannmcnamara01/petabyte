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
    
    public partial class EmployeeSchedule
    {
        public int id { get; set; }
        public string Day { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan BreakTimeBegin { get; set; }
        public System.TimeSpan BreakTimeend { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}