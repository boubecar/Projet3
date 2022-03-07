using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandeService.Commands.interfaces;
using CommonData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommandeService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class flialeController : ControllerBase
    {
        private IFilialeCommend _filialeCommend;
          flialeController(IFilialeCommend filialeCommend)
        {
            _filialeCommend = filialeCommend;
        }

        // [Microsoft.AspNetCore.Mvc.HttpGet]
        [HttpPost] 
        public async Task<IActionResult> Addfiliale(FilialeCommandModel model)
        {
            try
            {
                var filiale = await _filialeCommend.AddFilialeAsync(model);
                return StatusCode(StatusCodes.Status201Created, filiale);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }
        [HttpPut]
        public async Task<IActionResult> Updatefiliale(FilialeCommandModel model)
        {
            try
            {
                var bol = await _filialeCommend.UpdateFilialeAsync(model);
                if (bol == true)

                    return StatusCode(StatusCodes.Status200OK);
                return StatusCode(StatusCodes.Status304NotModified);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletefiliale(int id)
        {
            try
            {
                var bol = await _filialeCommend.DeleteFilialeAsync(id);
                if (bol == true)

                    return StatusCode(StatusCodes.Status200OK);
                return StatusCode(StatusCodes.Status304NotModified);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }
    }

}
    