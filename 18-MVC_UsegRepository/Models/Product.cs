namespace _18_MVC_UsegRepository.Models
{
    public class Product
    {
        public int ID { get; set; } 
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price {  get; set; } 
        public string Category {  get; set; }   
        public short Stock {  get; set; }   
    }
}
