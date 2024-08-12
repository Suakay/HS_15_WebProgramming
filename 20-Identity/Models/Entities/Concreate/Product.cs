using _20_Identity.Models.Entities.Interface;

namespace _20_Identity.Models.Entities.Concreate
{
    public class Product : BaseEntity, IEntity<int>
    {
        public int ID { get ; set ; }
    }
}
