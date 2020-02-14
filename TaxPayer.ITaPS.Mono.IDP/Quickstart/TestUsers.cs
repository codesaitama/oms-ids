// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityServer4.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "1771116F-BDE6-4D0F-A5A2-BF64D7731AA8",
                Username = "somad",
                Password = "password",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Somad Yessoufou"),
                    new Claim(JwtClaimTypes.GivenName, "Somad"),
                    new Claim(JwtClaimTypes.FamilyName, "Yessoufou"),
                    new Claim(JwtClaimTypes.Email, "somad.yessoufou@persol.net"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    //new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    //new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser
            {
                SubjectId = "961C6F16-7678-4B35-8088-A86BC60C11BC",
                Username = "eric",
                Password = "password",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Eric Boateng"),
                    new Claim(JwtClaimTypes.GivenName, "Eric"),
                    new Claim(JwtClaimTypes.FamilyName, "Boateng"),
                    new Claim(JwtClaimTypes.Email, "eric.boateng@persol.net"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    //new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                    //new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json),
                    //new Claim("location", "somewhere")
                }
            }
        };
    }
}