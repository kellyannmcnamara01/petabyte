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
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Feeedbacks = new HashSet<Feeedback>();
            this.GiftBills = new HashSet<GiftBill>();
            this.PatientsRooms = new HashSet<PatientsRoom>();
            this.Requests = new HashSet<Request>();
        }
    
        public int patientId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public System.DateTime DOB { get; set; }
        public string gender { get; set; }
        public string physican { get; set; }
        public System.DateTime joinDate { get; set; }
        public Nullable<int> contactId { get; set; }
        public Nullable<int> addressId { get; set; }
        public string healthCardNum { get; set; }
        public Nullable<int> emerageContactID { get; set; }
        public Nullable<int> insuranceId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Allergies { get; set; }
        public string relationship { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string postal { get; set; }
    
        public virtual Addresses1 Addresses1 { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual EmerageContact EmerageContact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feeedback> Feeedbacks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiftBill> GiftBills { get; set; }
        public virtual Insurance Insurance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientsRoom> PatientsRooms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Requests { get; set; }
    }
}
