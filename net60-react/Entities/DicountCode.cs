namespace net60_react
{
    public class DiscountCode
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Discount { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
    }
}