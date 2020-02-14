using Microsoft.AspNetCore.Identity;
using System;

namespace TaxPayer.ITaPS.Mono.IDP.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Discriminator { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public Guid iUser { get; set; }
        public Guid iStatus { get; set; }
        public DateTime dCreateDate { get; set; }
    }
}
