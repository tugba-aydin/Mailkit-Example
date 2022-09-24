using MailAPI.Abstracts;
using MailAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IMailService mailService;
        public EmailController(IMailService _mailService)
        {
            mailService = _mailService; 
        }
        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest mailRequest)
        {
            try
            {
                await mailService.SenEmailAsync(mailRequest);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
