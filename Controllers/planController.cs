using Microsoft.AspNetCore.Mvc;

namespace GymManagmentSystem.Controllers
{
    #region video06 RazorPages
    public class planController:Controller
    {
        //BaseUrl/plans/test
        public IActionResult Test()
        {
            return View(); //Razor page called Test 
        }
    }
    #endregion
}
