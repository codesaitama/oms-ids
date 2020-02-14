using Microsoft.AspNetCore.Identity;
using System;

namespace OMS.IDS.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base()
        {

        }

        public ApplicationRole(string roleName) : base(roleName)
        {

        }

        public ApplicationRole(string roleName, string Description, DateTime creationDate) : base(roleName)
        {
            this.Description = Description;
            this.CreationDate = creationDate;
        }

        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
