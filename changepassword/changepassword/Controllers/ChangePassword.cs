using Microsoft.AspNetCore.Mvc;

namespace changePassword.Controllers
{
    
    public class ChangePassword : Controller
    {
        [Route("change-password")]
        public async Task <IActionResult> changepassword()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
 