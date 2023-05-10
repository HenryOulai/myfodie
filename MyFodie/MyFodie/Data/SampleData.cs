using MyFodie.Models;

namespace MyFodie.Data
{
    public class SampleData
    {
        public static void Create(AppDbContext database)
        {
            // If there are no fake accounts, add some.
            string fakeIssuer = "https://example.com";
            if (!database.Accounts.Any(a => a.OpenIDIssuer == fakeIssuer))
            {
                database.Accounts.Add(new Account
                {
                    OpenIDIssuer = fakeIssuer,
                    OpenIDSubject = "1111111111",
                    Name = "Brad",
                    Telephone = "4324324",
                    Address = "Los Angles",
                    Created_at = DateTime.Now,
                });
                database.Accounts.Add(new Account
                {
                    OpenIDIssuer = fakeIssuer,
                    OpenIDSubject = "2222222222",
                    Name = "Angelina",
                    Telephone = "4324324",
                    Address = "Los Angles",
                    Created_at= DateTime.Now,
                });
                database.Accounts.Add(new Account
                {
                    OpenIDIssuer = fakeIssuer,
                    OpenIDSubject = "3333333333",
                    Name = "Will",
                    Telephone = "4324324",
                    Address = "Los Angles",
                    Created_at =DateTime.Now,
                });
            }

            database.SaveChanges();
        }
    }
}
