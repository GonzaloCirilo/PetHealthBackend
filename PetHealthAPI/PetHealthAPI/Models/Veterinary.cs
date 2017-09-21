//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetHealthAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Veterinary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Veterinary()
        {
            this.LocationPhoto = new HashSet<LocationPhoto>();
        }
    
        public int VeterinaryId { get; set; }
        public string Name { get; set; }
        public string PresentationVid { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string OpeningHours { get; set; }
        public Nullable<int> SocialURLId { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationPhoto> LocationPhoto { get; set; }
    }
}
