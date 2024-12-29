using Microsoft.AspNetCore.Mvc;

namespace ModeloPadrao.Controllers;

public class AuthenticationController : Controller
{
    public IActionResult AuthenticationForgotPassword()
    {
        return View();
    }
    
    public IActionResult AuthenticationLockscreen()
    {
        return View();
    }    
    
    public IActionResult AuthenticationResetPassword()
    {
        return View();
    }
    
    public IActionResult AuthenticationSigninWithHeaderFooter()
    {
        return View();
    }    
    public IActionResult AuthenticationSignin()
    {
        return View();
    }    
    public IActionResult AuthenticationSignupWithHeaderFooter()
    {
        return View();
    }
    public IActionResult AuthenticationSignup()
    {
        return View();
    }
}
