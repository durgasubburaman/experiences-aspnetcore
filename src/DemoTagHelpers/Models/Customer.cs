using System;
using System.ComponentModel;

namespace DemoTagHelpers.Models
{
    public class Customer
    {
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [DisplayName("Prénom")]
        public string FirstName { get; set; }

        [DisplayName("Nom")]
        public string LastName { get; set; }

        [DisplayName("Titre")]
        public string Title { get; set; }

        [DisplayName("Adresse (ligne 1)")]
        public string AddressLine1 { get; set; }

        [DisplayName("Adresse (ligne 2)")]
        public string AddressLine2 { get; set; }

        [DisplayName("Ville")]
        public string City { get; set; }

        [DisplayName("Code postal")]
        public string ZipCode { get; set; }

        [DisplayName("Pays")]
        public string Country { get; set; }
        
        public bool IsReadonly { get; set; }
    }
}
