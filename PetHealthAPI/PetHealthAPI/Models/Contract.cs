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
    
    public partial class Contract
    {
        public int ContractId { get; set; }
        public int VetId { get; set; }
        public int VeterinaryId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Status { get; set; }
    
        public virtual Vet Vet { get; set; }
        public virtual Veterinary Veterinary { get; set; }
    }
}
