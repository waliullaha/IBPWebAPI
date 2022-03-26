using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts(){
            return "this will be list of product";
        }
        [HttpGet("{id}")]
        public string GetProduct(int id){
            return "single product";
        }
    }
}