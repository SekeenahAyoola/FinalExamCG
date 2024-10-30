using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMAmvc.Models.entities;

namespace TMAmvc.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        User GetById(string id);
        User GetByEmail(string email);
        User UpdateUser(User user);
        User DeleteUser(User user);
        IEnumerable<User> GetAll();

    }
}