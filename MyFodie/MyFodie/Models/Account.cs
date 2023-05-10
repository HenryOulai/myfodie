namespace MyFodie.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string? OpenIDIssuer { get; set; }
        public string? OpenIDSubject { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Telephone { get; set; }
        public DateTime Created_at { get; set; }

    }
}
