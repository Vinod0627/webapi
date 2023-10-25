using AuthenticationAndAuthorization.DBModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAndAuthorization.Controllers
{
    [Authorize]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductDataContext _context = new ProductDataContext();


        [HttpGet] //get
        [Route("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok( "success");
        }

        [HttpGet]
        [Route("GetProductByCode")]
        public async Task<IActionResult> GetProductByCode(string ProductCode)
        {
            return Ok(_context.TblProducts.Where(e=>e.ProductCode==ProductCode).FirstOrDefault());
        }
    }
}
