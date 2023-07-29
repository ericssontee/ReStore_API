namespace API.DTOs
{ //DTO - data transfer object
    public class BasketDto
    {
        public int Id { get; set;}
        public string BuyerId { get; set; }
        public List<BasketItemDto> Items { get; set; }
    }
}