using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMAmvc.Models.entities;
using TMAmvc.Models.Dtos;

namespace TMAmvc.Services.Interfaces
{
    public interface IUserService
    {
        public User RegisterUser(RegisterUserDto registerUser);
        public User LoginUser(LoginUserDto loginUser);
    }
}