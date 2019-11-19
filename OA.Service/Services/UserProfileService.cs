using OA.DomainEntities;
using OA.Repo.Interfaces;
using OA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service.Services
{
    public class UserProfileService : IUserProfileService
    {
        private IRepository<UserProfile> _userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
        public UserProfile GetUserProfile(long Id)
        {
            return _userProfileRepository.Get(Id);
        }
    }
}
