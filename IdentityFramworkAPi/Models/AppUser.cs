using Microsoft.AspNetCore.Identity;

namespace IdentityFramworkAPi.Models;

public class AppUser : IdentityUser
{
    public string Custom { get; set; }
}
