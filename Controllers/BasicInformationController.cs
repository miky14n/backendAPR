using appPrevencionRiesgos.Data.Repository;
using appPrevencionRiesgos.Exceptions;
using appPrevencionRiesgos.Model;
using appPrevencionRiesgos.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace appPrevencionRiesgos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicInformationController : Controller
    {
        private IBasicInformationService _informationService;
        public BasicInformationController(IBasicInformationService informationService)
        {
            _informationService = informationService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicInformationModel>>> GetAllInformationAsync()
        {
            try
            {
                var informationList = await _informationService.GetAllInformationAsync();
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
        public async Task<ActionResult<BasicInformationModel>> GetOneInformationAsync(string id)
        {
            try
            {
                var information = await _informationService.GetOneInformationAsync(id);
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
        public async Task<ActionResult<BasicInformationModel>> PostInformationAsync([FromBody] BasicInformationModel information)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var newInformation = await _informationService.CreateInformation(information);
                var newId = Convert.ToString(newInformation.Id);
                return Created($"/api/basicinformation/{newId}", newInformation);
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
        public async Task<ActionResult<BasicInformationModel>> PutInformationAsync(string id, [FromBody] BasicInformationModel information)
        {
            try
            {
                information.Id = new ObjectId(id);
                var updatedInformation = await _informationService.UpdateInformationAsync(id, information);
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
                await _informationService.DeleteInformationAsync(id);
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