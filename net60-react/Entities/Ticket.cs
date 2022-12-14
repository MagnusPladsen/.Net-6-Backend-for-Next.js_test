namespace net60_react.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Icon { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

    }
}