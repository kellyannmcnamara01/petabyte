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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class JobPosting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobPosting()
        {
            this.JobApplicants = new HashSet<JobApplicant>();
        }

        public int jobId { get; set; }

        [Required(ErrorMessage = "Please enter a job title")]
        [DisplayName("Job Title")]
        [MaxLength(50)]
        public string jobTitle { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Please enter a job description")]
        [DisplayName("Job Description")]
        public string jobDesc { get; set; }

        [Required(ErrorMessage = "Please enter the author")]
        [DisplayName("Author")]
        public int employeeId { get; set; }

        [DisplayName("Time Stamp")]
        public Nullable<System.DateTime> timestamp { get; set; }

        [Required(ErrorMessage = "Please enter a status")]
        [DisplayName("Status")]
        public string status { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<JobApplicant> JobApplicants { get; set; }
    }
}
