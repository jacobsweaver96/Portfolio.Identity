// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            { 
                new ApiScope("Catalog.WebApi", "Catalog.WebApi"),
                new ApiScope("Catalog.WebApp", "Catalog.WebApp"),
            };

        public static IEnumerable<Client> Clients =>
            new Client[] 
            {
                // Catalog Web Client login config
                new Client
                {
                    ClientId = "Catalog.Client",
                    AllowedGrantTypes = GrantTypes.Code,
                    // TODO: Finish Config
                },

                // Catalog Web App secret config
                new Client
                {
                    ClientId = "Catalog.WebApp",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        // TODO: Add client secret here
                    },
                    AllowedScopes =
                    {
                        "Catalog.WebApi",
                    },
                },
            };
    }
}