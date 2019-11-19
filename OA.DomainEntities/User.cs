
namespace OA.DomainEntities
{
    public class User : BaseEntity
    {
        public string UserName { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public virtual UserProfile UserProfile { set; get; }
    }
}
