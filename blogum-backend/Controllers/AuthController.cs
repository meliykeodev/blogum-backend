using System;
using System.Collections.Generic;
using blogum_core.dtos;
using blogum_core.Helpers;

namespace blogum_backend.Controllers
{
    public interface IAuthController
    {
        AuthToken AddToken(long userId);
        bool ExistsToken(long userId);
        AuthToken GetToken(long userId);
    }

    public class AuthController : IAuthController
    {
        private Dictionary<long, AuthToken> tokens = new Dictionary<long, AuthToken>();

        public AuthController() { }

        public AuthToken AddToken(long userId)
        {
            string token = CreateToken(userId);

            tokens.Add(userId, new AuthToken { Token = token, UserId = userId });

            return GetToken(userId);
        }

        public bool ExistsToken(long userId)
        {
            return tokens.ContainsKey(userId);
        }

        public AuthToken GetToken(long userId)
        {
            return tokens.GetValueOrDefault(userId);
        }

        private string CreateToken(long userId)
        {
            var encryptedValue = EncryptionHelper.Encrypt(userId.ToString());

            return encryptedValue;
        }
    }
}
