using _20_Identity.Models.Entities.Enums;
using _20_Identity.Models.Entities.Interface;
using Microsoft.AspNetCore.Identity;

namespace _20_Identity.Models.Entities.Concreate
{
    public class AppUser : IdentityUser<Guid>, IBaseEntity
    {
        public string CreatedBy { get ; set ; }
        public DateTime CreatedDate { get ; set; }
        public DateTime? ModifiedDate { get ; set ; }
        public Status Status { get ; set ; }
    }
}
