using appPrevencionRiesgos.Data.Repository;
using appPrevencionRiesgos.Exceptions;
using appPrevencionRiesgos.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace appPrevencionRiesgos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicInformationController : Controller
    {
        private IBasicInformationRepository dbContext = new BasicInformationRepository();

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicInformationModel>>> GetAllInformationAsync([FromQuery] string direction = "asc", string orderBy = "id")
        {
            try
            {
                var informationList = await dbContext.GetAllInformationAsync(direction, orderBy);
                return Ok(informationList);
            }
            catch (NotFoundElementException ex)
            {
                return NotFound(ex.Message);
            }
            catch (InvalidElementOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something happend.");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BasicInformationModel>> GetOneInformationAsync(string id, string showInformation)
        {
            try
            {
                bool showMoviesBoolean;
                if (!Boolean.TryParse(showInformation, out showMoviesBoolean))
                {
                    showMoviesBoolean = false;
                }

                var information = await dbContext.GetOneInformationAsync(id, showMoviesBoolean);
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

    }
}
