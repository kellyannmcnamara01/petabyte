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
    
    public partial class JobApplicant
    {
        public int jobAppId { get; set; }
        public int jobId { get; set; }
        public string appJobTitle { get; set; }
        public string appFirstName { get; set; }
        public string appLastName { get; set; }
        public string appEmail { get; set; }
        public string appLinkedIn { get; set; }
        public string appMessage { get; set; }
        public byte[] appCv { get; set; }
        public byte[] appOtherFile { get; set; }
    
        public virtual JobPosting JobPosting { get; set; }
    }
}
