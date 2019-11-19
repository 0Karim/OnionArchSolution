using OA.DomainEntities;
using OA.Repo.Interfaces;
using OA.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace OA.Service
{
    public class UserService : IUserService
    {

        private IRepository<User> _userRepository;
        private IRepository<UserProfile> _userProfileRepository;

        public UserService(IRepository<User> userRepository , IRepository<UserProfile> userProfileRepository)
        {
            _userRepository = userRepository;
            _userProfileRepository = userProfileRepository;
        }

        public void DeleteUser(long Id)
        {
            var userProfile = _userProfileRepository.Get(Id);
            _userProfileRepository.Delete(userProfile);
            var user = GetUser(Id);
            _userRepository.Delete(user);
        }

        public User GetUser(long Id)
        {
            return _userRepository.Get(Id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public void InsertUser(User user)
        {
            _userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }
    }
}
