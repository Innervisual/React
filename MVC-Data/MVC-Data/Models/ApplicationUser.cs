using Microsoft.AspNetCore.Identity;

namespace MVC_Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthDate { get; set; }
    }
}
