using CaptaTecnologiaAPI.Models;
using CaptaTecnologiaAPI.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CaptaTecnologiaAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(typeof(StatusCodeResult), 400)]
    [ProducesResponseType(typeof(StatusCodeResult), 500)]
    public class MoedaController : ControllerBase
    {
        private readonly IServiceCotacaoMoeda _serviceCotacaoMoeda;

        public MoedaController(IServiceCotacaoMoeda serviceCotacaoMoeda)
        {
            _serviceCotacaoMoeda = serviceCotacaoMoeda;
        }

        [HttpGet]
        public async Task<ActionResult<MoedaCotacao>> GetMoedaCotacao()
        {
            try
            {
                return Ok(await _serviceCotacaoMoeda.GetCotacaoMoeda());

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }


}
