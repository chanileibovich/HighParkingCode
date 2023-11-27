namespace HighParking.Core.Entities
{
    public class Customers
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }

        public string Phone { get; set; }
        public int? Code { get; set; }
        public string? Credit { get; set; }
        public string? Bit { get; set; }
        public Status Status { get; set; }
        public int Points { get; set; }

    }
}
