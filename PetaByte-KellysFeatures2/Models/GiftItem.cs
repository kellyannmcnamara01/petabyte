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
    
    public partial class giftItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public giftItem()
        {
            this.carts = new HashSet<cart>();
            this.orderPlaceds = new HashSet<orderPlaced>();
        }
    
        public int giftItemId { get; set; }
        public string giftItemName { get; set; }
        public decimal giftItemPrice { get; set; }
        public string giftItemDescription { get; set; }
        public Nullable<System.DateTime> lastUpdated { get; set; }
        public int giftTypeid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cart> carts { get; set; }
        public virtual giftType giftType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderPlaced> orderPlaceds { get; set; }
    }
}
