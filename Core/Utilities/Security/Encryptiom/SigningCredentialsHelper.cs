﻿using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryptiom
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);
            
        }
    }
}
