using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using blogum_core.dtos;
using blogum_core.Helpers;
using blogum_db.dtos;
using blogum_db.models;
using blogum_db.repositories;
using Microsoft.AspNetCore.Mvc;

namespace blogum_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthController _authController;

        public UserController(
            IUserRepository userRepository,
            IAuthController authController
            )
        {
            _userRepository = userRepository;
            _authController = authController;
        }

        [HttpGet]
        public string Test()
        {
            return "user controller is work!";
        }

        [HttpPost]
        [Route("Signup")]
        public async Task<UserDto> Signup([FromBody]UserDto user)
        {
            user.Password = EncryptionHelper.Encrypt(user.Password);

            var entity = AppMapper.Map<User>(user);

            var result = await _userRepository.Insert(entity);

            user.Id = result;

            return user;
        }

        [HttpPost]
        [Route("Signin")]
        public async Task<BaseResponse> Signin([FromBody]AuthenticationDto dto)
        {
            string hashedPassword = EncryptionHelper.Encrypt(dto.Password);

            var zz = AppMapper.Map<UserDto>(dto);

            var result = (await _userRepository.GetAll(o => o.Email.ToLower() == zz.Email.ToLower()));

            var user = AppMapper.Map<UserDto>(result);

            if (user != null)
            {
                if (user.Password == hashedPassword)
                {
                    var tokenModel = _authController.GetToken((long)user.Id);

                    if (tokenModel == null)
                    {
                        tokenModel = _authController.AddToken((long)user.Id);
                    }

                    if (tokenModel.HasExpired)
                    {
                        return new BaseResponse(false, null, "Token has expired.");
                    }

                    return new BaseResponse(true, new { User = user, Token = tokenModel });
                }
                else
                {
                    return new BaseResponse(false, null, "Wrong password!");
                }
            }

            return new BaseResponse(false, null, "User not found!");
        }
    }
}
