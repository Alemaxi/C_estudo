using dotnetsln2.Business;
using dotnetsln2.Data.Converter.Implementations;
using dotnetsln2.Data.VO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetsln2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize("Bearer")]
    public class EnderecoController : ControllerBase
    {
        private readonly ILogger<EnderecoController> _logger;
        private readonly IEnderecoBusiness _business;
        private EnderecoConverter converter;

        public EnderecoController(ILogger<EnderecoController> logger, IEnderecoBusiness business)
        {
            _logger = logger;
            _business = business;
            converter = new EnderecoConverter();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(converter.Parse(_business.FindAll()));
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            return Ok(converter.Parse(_business.FindById(id)));
        }

        [HttpPost]
        public IActionResult Post([FromBody] EnderecoVO item)
        {
            var result = _business.Create(converter.Parse(item));
            return Ok(converter.Parse(result));
        }

        [HttpPut]
        public IActionResult Put([FromBody] EnderecoVO item)
        {
            var result = _business.Edit(converter.Parse(item));
            return Ok(converter.Parse(result));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _business.Delete(id);
            return Ok();
        }


    }
}
