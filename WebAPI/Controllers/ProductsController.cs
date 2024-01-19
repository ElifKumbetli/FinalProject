using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupling -- gevşek bağlılık
        //naming convention --isimlendirme standardı
        //IoC Container --Inversion of Control --Değişimin kontrolü
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //Dependency chain -- bağımlılık zinciri
            var result = _productService.GetAll();
            return result.Data;       

        }

    }
}
