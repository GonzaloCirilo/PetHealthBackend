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
    
    public partial class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
        public virtual Vet Vet { get; set; }
    }
}
