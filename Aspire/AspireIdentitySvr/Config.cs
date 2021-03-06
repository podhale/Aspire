﻿
using IdentityServer4.Models;
using System.Collections.Generic;

namespace AspireIdentitySvr
{
    public static class Config
    {
        public static IEnumerable<ApiResource> GetMyAllApi()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "My API")
            };
        }
            

        public static IEnumerable<Client> Clients()
        {
            return new List<Client>
             {
                new Client
                {
                    ClientId = "client",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    // secret for authentication
                    ClientSecrets =
                     {
                        new Secret("secret".Sha256())
                     },

                            // scopes that client has access to
                     AllowedScopes = { "api1" }
                 }};
        }
    }
}