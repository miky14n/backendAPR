using appPrevencionRiesgos.Exceptions;
using appPrevencionRiesgos.Model;
using appPrevencionRiesgos.Model.Security;
using appPrevencionRiesgos.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace appPrevencionRiesgos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInformationController : Controller
    {
        private IUserInformationService _userService;
        public UserInformationController(IUserInformationService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserInformationModel>>> GetAllUsersAsync()
        {
            try
            {
                var informationList = await _userService.GetAllUsersAsync();
                return Ok(informationList);
            }
            catch (NotFoundElementException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something happend.");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserInformationModel>> GetOneUserAsync(string id)
        {
            try
            {
                var information = await _userService.GetOneUserAsync(id);
                return Ok(information);
            }
            catch (NotFoundElementException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something happend.");
            }
        }

        [HttpGet("uid/{uid}")]
        public async Task<ActionResult<UserInformationModel>> GetByEmailAsync(string uid)
        {
            try
            {
                var information = await _userService.GetByEmailAsync(uid);
                return Ok(information);
            }
            catch (NotFoundElementException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something happend.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserInformationModel>> PostUserAsync([FromBody] UserInformationModel information)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var newInformation = await _userService.CreateUser(information);
                var newId = Convert.ToString(newInformation.Id);
                return Created($"/api/userinformation/{newId}", newInformation);
            }
            catch (NotFoundElementException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something happend.");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserInformationModel>> PutUserInformationAsync(string id, [FromBody] UserInformationModel information)
        {
            try
            {
                information.Id = new ObjectId(id);
                var updatedInformation = await _userService.UpdateUserAsync(id, information);
                return Ok(updatedInformation);
            }
            catch (NotFoundElementException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteInformation(string id)
        {
            try
            {
                await _userService.DeleteUserAsync(id);
                return Ok();
            }
            catch (NotFoundElementException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something happend.");
            }
        }
    }
}
