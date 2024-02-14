namespace HighParking.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string StrId { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Phone { get; set; }
        public int Code { get; set; }
        public string Credit { get; set; }
        public Status Status { get; set; }
        public int Points { get; set; }

        public List<Invoicing> Invoicings { get; set; }


    }
}
