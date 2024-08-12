namespace _20_Identity.Models.Entities.Interface
{
    public interface  IEntity<T>
    {
        public T ID { get; set; }
    }
}
