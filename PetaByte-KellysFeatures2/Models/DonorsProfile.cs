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
    
    public partial class DonorsProfile
    {
        public int donorProfileId { get; set; }
        public Nullable<int> donorsId { get; set; }
        public string donorsMessage { get; set; }
    
        public virtual Donor Donor { get; set; }
    }
}
