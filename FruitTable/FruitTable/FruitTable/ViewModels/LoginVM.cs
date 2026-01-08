using System.ComponentModel.DataAnnotations;

namespace FruitTables.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string UsernameOrEmail { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
