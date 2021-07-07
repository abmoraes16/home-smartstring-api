using Microsoft.AspNetCore.Mvc;
using SmartString.Domain.Service;

namespace SmartString.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmartStringController : Controller
    {
        private readonly IProccessString _proccessString;

        public SmartStringController(IProccessString proccessString)
        {
            _proccessString = proccessString;
        }

        [HttpPost("v1/palindromic/{value}")]
        public ActionResult SearchPalindromicString(string value)
        {
            string palindromic = _proccessString.SearchPalindromicString(value);
            return Ok(palindromic);
        }
    }
}