using GymManagmentSystem.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystem.Controllers
{
    #region video06 RazorPages
    public class planController:Controller
    {
        //BaseUrl/plans/test
        //public IActionResult Test()
        //{
        //    return View(); //Razor page called Test 
        //}


#region video 07
        //List of all plans
        public async Task<IActionResult> index()
        {
            using GymDbContext context = new GymDbContext();

            var plans = await context.Plans.ToListAsync();
            return View(plans); //Razor page called Index

        }
    #endregion
    }
#endregion
}
