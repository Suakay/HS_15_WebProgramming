using _20_Identity.Models.Entities.Enums;
using _20_Identity.Models.Entities.Interface;

namespace _20_Identity.Models.Entities.Concreate
{
    public abstract class BaseEntity : IBaseEntity
    {
        public string CreatedBy { get ; set; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime? ModifiedDate { get; set ; }
        public Status Status { get ; set ; }
    }
}
