
using OA.DomainEntities;

namespace OA.Service.Interfaces
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long Id);
    }
}
