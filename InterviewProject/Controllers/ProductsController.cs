using Businnes.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getallbycategoryname")]
        public IActionResult GetAllCategoryName(int category)
        {
            var result = _productService.GetByCategory(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
        [HttpPut]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
        [HttpDelete]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

    }
}
