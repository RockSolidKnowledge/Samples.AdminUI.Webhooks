using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using Microsoft.AspNetCore.Cors;

namespace WebHooksClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordResetController : ControllerBase
    {

        [Authorize("webhook")]
        [HttpPost]
        public IActionResult PasswordReset([FromBody]PasswordResetDTO dto)
        {
            if (string.IsNullOrEmpty(dto.email))
            {
                return BadRequest("Invalid email");
            }

            return Ok();
        }

    }

    public class PasswordResetDTO
    {
        public string email;
    }

    
}