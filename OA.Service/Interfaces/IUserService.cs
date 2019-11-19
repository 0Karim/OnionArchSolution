using OA.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();

        User GetUser(long Id);

        void InsertUser(User user);

        void UpdateUser (User user);

        void DeleteUser(long Id);
    }
}
