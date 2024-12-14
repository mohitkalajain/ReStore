using API.Helper;
using API.Helper.Constants;
using API.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class ProductsController : BaseApiController
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(IProductService productService, ILogger<ProductsController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _productService.Get();
                return ResponseHandler.CreateResponse(result);
            }
            catch (Exception ex)
            {
                return ResponseHandler.HandleException(ex, _logger);
            }
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                if (id == 0)
                    return ResponseHandler.CreateResponse(ResponseVM.InvalidRequest(MessageConstants.InvalidValue));

                var result = await _productService.Get(id);
                return ResponseHandler.CreateResponse(result);
            }
            catch (Exception ex)
            {
                return ResponseHandler.HandleException(ex, _logger);
            }
        }
    }
}