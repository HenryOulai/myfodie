namespace MyFodie.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string OpenIDIssuer { get; set; }
        public string OpenIDSubject { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public DateTime Created_at { get; set; }

    }
}
