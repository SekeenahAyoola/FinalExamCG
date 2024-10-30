using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMAmvc.Models.entities;
using TMAmvc.Models.Dtos;
using TMAmvc.Services.Interfaces;
using TMAmvc.Repositories.Interfaces;

namespace TMAmvc.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            userRepository = _userRepository;
        }

        public User RegisterUser(RegisterUserDto registerUser)
        {
            User user = new User{};
            user.FirstName = registerUser.FirstName;
            user.LastName = registerUser.LastName;
            user.Role = registerUser.Role;
            user.PhoneNumber = registerUser.PhoneNumber;
            user.Email = registerUser.Email;
            user.Password = registerUser.Password;
            user.Wallet = 000000000000;
            user.Gender = registerUser.Gender;
            user.Age = registerUser.Age;
            user.DateOfBirth = registerUser.DateOfBirth;
            //profilpicturepath
            user.IsDeleted = false;
            user.DateUpdated = user.DateCreated;
            return user;
        }
        public User LoginUser(LoginUserDto loginUser)
        {
            User user = _userRepository.GetByEmail(loginUser.Email);

            return user;
        }
    }
}