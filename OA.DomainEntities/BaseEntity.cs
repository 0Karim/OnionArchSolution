using System;

namespace OA.DomainEntities
{
    public class BaseEntity
    {
        public Int64 Id { set; get; }
        public DateTime AddedDate { set; get; }
        public DateTime ModifiedDate { set; get; }
        public string IPAddress { set; get; }
    }
}
