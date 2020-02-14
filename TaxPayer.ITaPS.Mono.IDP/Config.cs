// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace TaxPayer.ITaPS.Mono.IDP
{
    public class Config
    {
        static string strFirstApiUrls = IDPSettingsConfiguration.Current.OMSAPI1;
        static string strSecondApiUrls = IDPSettingsConfiguration.Current.OMSAPI2;
        static string strThirdApiUrls = IDPSettingsConfiguration.Current.OMSAPI3;

        //string strApiNames = Startup.Configuration["IDPSettings: ApiName"];
        //string strApiIds = Startup.Configuration["IDPSettings:ApiId"];
        //private static string strFirstItapsApiUrls = Startup.Configuration["IDPSettings:ITAPSTPAPIs"];
        //private static string strSecondItapsApiUrls = Startup.Configuration["IDPSettings:ITAPSTPAPIs1"];

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResources.Address(),
                new IdentityResource("roles", "Your role(s)", new List<string> { "role"}),
                new IdentityResource("country", "The country you're living in", new List<string> { "country" }),
                new IdentityResource("subscriptionlevel", "Your subscription level", new List<string> { "subscriptionlevel" })
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("omsyapi", "Outlet Management System Admin API",new List<string> { "role" })
                {
                    ApiSecrets = { new Secret("&r@$$o$%Kit@pS$e#$T!@#$2019".Sha256()) }
                },
            };
        }

        public static IEnumerable<Client> GetClients(IConfiguration configuration)
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "omsimplicit",
                    ClientName = "Outlet Management System Client",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = new [] {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "omsyapi"
                    },
                    RequireConsent = false,
                    AllowAccessTokensViaBrowser = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    AllowOfflineAccess = true,
                    AllowedCorsOrigins = new []
                    {
                        $"{strFirstApiUrls}",
                        $"{strSecondApiUrls}",                        
                        $"{strThirdApiUrls}"
                    },
                    RedirectUris =  new []
                    {
                        $"{strFirstApiUrls}/swagger/oauth2-redirect.html",
                        $"{strSecondApiUrls}/swagger/oauth2-redirect.html",
                        $"{strFirstApiUrls}",
                        $"{strSecondApiUrls}"
                    },
                    PostLogoutRedirectUris =
                    {
                        $"{strFirstApiUrls}/swagger",
                        $"{strSecondApiUrls}/swagger",
                        $"{strFirstApiUrls}",
                        $"{strSecondApiUrls}"
                    }
                }
            };
        }        
    }
}
