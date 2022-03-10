using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaAPI.DAL.Models.Auth;
using ClinicaAPI.DAL.Models.User;

namespace ClinicaAPI.Services.AuthServices
{
    public interface IAuthService
    {
        Task<UserAuthenticatedModel> Register(RegisterModel model);
        Task<UserAuthenticatedModel> Login(LoginModel model);
    }
}