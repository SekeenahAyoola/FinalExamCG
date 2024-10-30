using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMAmvc.DBContext;
using Dapper;
using MySql.Data.MySqlClient;
using TMAmvc.Models.entities;

namespace TMAmvc.Repositories.Implementation
{
    public class UserRepository
    {
        private readonly AppDbContext context;
        public UserRepository(AppDbContext _context)
        {
            context = _context;
        }

        User CreateUser(User user)
        {
            context.CreateTableUser();
            string query = $"insert into User (Id, FirstName, LastName , Email, Password,PhoneNumber,Gender,Age,Role,IsDeleted,DateCreated,DateUpdated,Wallet) values('{user.Id}','{user.FirstName}','{user.LastName}','{user.Email}','{user.Password}','{user.PhoneNumber}','{user.Gender}', {user.Age},'{user.Role}',{user.IsDeleted},'{user.DateCreated}','{user.DateUpdated}',{000000})";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var asd = connection.Execute(query);
                return user;
            } 
        }

        User GetById(string id)
        {
            string query = $"SELECT * FROM user where id = {id}";
            using (var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var user = connection.QueryFirstOrDefault<User>(query);
                return user;
            }
        }

        User GetByEmail(string email)
        {
            string query = $"SELECT * FROM user where Email = '{email}'";
            using (var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var user = connection.QueryFirstOrDefault<User>(query);
                return user;
            }
        }

        User UpdateUser(User user)
        {
            string query = $"UPDATE user FirstName = '{user.FirstName}' LastName = '{user.LastName}' Age = {user.Age} DateUpdated = '{user.DateUpdated}'where Id = {user.Id}";
            using (var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var updateUser = connection.Execute(query);
                return user;
            }
        }

        User DeleteUser(User user)
        {
            string query = $"UPDATE user IsDeleted = {user.IsDeleted} DateUpdated = '{user.DateUpdated}' where Id = {user.Id}";
            using (var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var a = connection.Execute(query);
                return user;
            }
        }

        IEnumerable<User> GetAll()
        {
            var query = $"SELECT * FROM User" ;
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var users = connection.Query<User>(query);
                return users.ToList();
            }

        }
    }
}