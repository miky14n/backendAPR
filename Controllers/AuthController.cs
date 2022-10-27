using appPrevencionRiesgos.Model.Security;
using appPrevencionRiesgos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using appPrevencionRiesgos.Services.Security;
using appPrevencionRiesgos.Model;

namespace appPrevencionRiesgos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IBasicInformationService userService;

        public AuthController(IBasicInformationService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public async Task<List<BasicInformationModel>> GetAllBasicInformationAsync()
        {
            return await userService.GetAllBasicInformationAsync();
        }
        // /api/auth/userx  
        /*
        [HttpPost("User")]
        public async Task<IActionResult> RegisterAsync([FromBody] UserModel model)
        {
            await userService.CreateAsync(model);

            return CreatedAtAction(nameof(Get), new { mail = model.email }, model);
        }
        */
       
    }
}
