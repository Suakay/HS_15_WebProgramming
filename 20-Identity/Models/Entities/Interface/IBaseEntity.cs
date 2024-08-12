using _20_Identity.Models.Entities.Enums;

namespace _20_Identity.Models.Entities.Interface
{
    public interface IBaseEntity
    {
        public string CreatedBy {  get; set; }  
        public DateTime CreatedDate { get; set; }   
        public DateTime? ModifiedDate { get; set; } 
        public Status Status { get; set; }
    }
}
