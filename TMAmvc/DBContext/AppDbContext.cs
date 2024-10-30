using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;


namespace TMAmvc.DBContext
{
    public class AppDbContext
    {
       public string connectionStrings = "Server=localhost;User=root;Database=MVCTMADapper;Password=ISTHAXX";

        private void Execution(string query)
        {
            using(var connection = new MySqlConnection(connectionStrings))
            {
                connection.Open();
                connection.Execute(query);
            }
        }

        public void CreateSchema()
        {
            var query = "create schema if not exists MVCTMADapper";
            var connectionString = "Server=localhost;User=root;Password=ISTHAXX";
            using(var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query);
            }
        }
        public void CreateTableUser()
        {
            var query = @"create table if not exists user(Id varchar(225), IsDeleted bool, DateCreated varchar(50) , DateUpdated varchar(50),FirstName varchar(225) not null,LastName varchar(225) not null,Email varchar(225) unique not null, Password varchar(225) not null ,Gender enum('Male', 'Female'),PhoneNumber varchar(11),Age int not null,Role varchar(225),Wallet decimal,primary key(Id))";
            Execution(query);
        }
        public void CreateTuteeTable()
        {
            var query = @"create table if not exists Tutee(Id varchar(225), UserId varchar(225), HasTutor bool, TuteeLevel enum ('JAMB','JSS1','JSS2', 'JSS3','SS1','SS2','SS3') not null,primary key(Id), foreign key(UserId) references User(Id))";
            Execution(query);
        }

        public void CreateTutorTable()
        {
            var query = @"create table if not exists Tutor(Id varchar(225),UserId varchar(225), HasTutee bool, CVImagePath varchar (225), primary key(Id), foreign key(UserId) references User(Id))";
            Execution(query);
        }
        public void CreateAdminTable()
        {
            var query = @"create table if not exists Admin(Id varchar(225),UserId varchar(225), primary key(Id), foreign key(UserId) references User(Id))";
            Execution(query);
        }

        public void CreateCommentTable()
        {
            var query = @"create table if not exists Comment(Id varchar(225), IsDeleted bool, DateCreated varchar(50), DateModified varchar(50),TutorId int ,primary key(Id), foreign Key (TuteeId) references Tutee (Id))";
            Execution(query);
        }
        public void CreateRatingTable()
        {
            var query = @"create table if not exists Rating(Id varchar(225), IsDeleted bool, DateCreated varchar(50), DateModified varchar(50),TutorId int ,primary key(Id), foreign Key (TutorId) references Tutor (Id))";
            Execution(query);
        }

        public void CreateSuperAdminTable()
        {
            var query = @"create table if not exists SuperAdmin(Id varchar(225),UserId varchar(225), primary key(Id), foreign key(UserId) references User(Id) )";
            Execution(query);
        }
        public void CreateTutorTuteeTable()
        {
            var query = @"create table if not exists TutorTutee(Id varchar(225),TuteeId varchar(225),TutorId varchar(225), primary key(Id), foreign key(TuteeId) references Tutee(Id), foreign key(TutorId) references Tutor(Id) )";
            Execution(query);
        }
    }
}