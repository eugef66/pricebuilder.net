using Microsoft.AspNetCore.Mvc;

namespace ef.pricebuilder.net.api.Controllers
{
    [ApiController]
    [Route("[category]")]
    public class CategoryController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Category
            {
                Id = index,
                Name = $"{index}"
                
            })   .ToArray();
        }
    }
}