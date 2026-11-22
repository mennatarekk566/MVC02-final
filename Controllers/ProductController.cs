using Microsoft.AspNetCore.Mvc;
using MVC02.Models;

namespace MVC02.Controllers
{
    #region video 01

    //clr
    //[Route("[controller]")]
    public class ProductController : Controller
    {
        /// BaseUrl/Product/getbyid/12


        public IActionResult GetBYID(int id)
        {

            return Json(null);
        }

        //public IActionResult search (string term, int page  , int min_price)
        //{
        //    return Json(new {term, page, min_price});
        //}

        public IActionResult search(ProductFiltter productfilter)
        {
            return Json(new { productfilter.term, productfilter.page, productfilter.min_price });
        }
    }

    #endregion
}
