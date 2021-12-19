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
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;
        private readonly IPessoaBusiness _business;
        private PessoaConverter converter;

        public PessoaController(ILogger<PessoaController> logger, IPessoaBusiness business)
        {
            _logger = logger;
            _business = business;
            converter = new PessoaConverter();
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
        public IActionResult Post([FromBody] PessoaVO item)
        {
            var result = _business.Create(converter.Parse(item));
            return Ok(converter.Parse(result));
        }

        [HttpPut]
        public IActionResult Put([FromBody] PessoaVO item)
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
