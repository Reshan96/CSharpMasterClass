using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityFramworkAPi.Controllers;

public class TokenController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    public TokenController(UserManager<IdentityUser> manager)
    {
        _userManager = manager;
    }

    [Route("/token")]
    [HttpPost]
    public async Task<IActionResult> Create(string username, string password, string grant_type)
    {
        if (await IsValidUsernameAndPassword(username, password)) 
        {

        }
        else
        {
            return BadRequest("Invalid username or password");
        }
    }

    private async Task<bool> IsValidUsernameAndPassword(string username, string password)
    {
        return true;
    }

    private async Task<dynamic> GenerateToken(string username)
    {
        var user =
        {

        }
    }
}
