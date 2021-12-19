using dotnetsln2.Business;
using dotnetsln2.Data.VO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetsln2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly ILoginBusiness _business;

        public AuthController(ILogger<AuthController> logger, ILoginBusiness business)
        {
            _logger = logger;
            _business = business;
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult Signin([FromBody] UserVO user)
        {
            if (user == null) return BadRequest("Invalid client request");
            var token = _business.ValidateCredentials(user);

            if (token == null) return Unauthorized();
            return Ok(token);
        }


        [HttpPost]
        [Route("refresh")]
        public IActionResult Refresh([FromBody] TokenVO tokenVO)
        {
            if (tokenVO == null) return BadRequest("Invalid client request");
            var token = _business.ValidateCredentials(tokenVO);

            if (token == null) return BadRequest("Invalid client request");
            return Ok(token);
        }

        [HttpGet]
        [Route("revoke")]
        [Authorize("Bearer")]
        public IActionResult Revoke()
        {
            var user = User.Identity.Name;
            var result = _business.RevokeToken(user);

            if (!result) return BadRequest("Invalid client request");
            return NoContent();
        }


    }
}
