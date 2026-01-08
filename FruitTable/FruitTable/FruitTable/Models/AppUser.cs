using Microsoft.AspNetCore.Identity;

namespace FruitTables.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
