using AgencijaNekretnine;
using AgencijaNekretnine.Entiteti;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace APIagencijaNekretnine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KvartController : ControllerBase
    {
        [HttpGet]
        [Route("vratiKvartove")]//RADI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult vratiKvartove()
        {
            try
            {
                return new JsonResult(DTOmanager.vratiKvartove());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("dodajKvart")] //RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult dodajKvart([FromBody]KvartBasic kb)
        {
            try
            {
                DTOmanager.dodajKvart(kb);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("vratiKvart/{idk}")]//RADI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult vratiKvart([FromRoute]string idk)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiKvart(Convert.ToInt32(idk)));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("vratiKvartPoZoni/{zona}")]//RADI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult vratiKvartPoZoni([FromRoute] string zona)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiKvartPoZoni(Convert.ToInt32(zona)));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("izmeniKvart")]//RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult izmeniKvart([FromBody] KvartBasic kb)
        {
            try
            {
                DTOmanager.izmeniKvart(kb);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("obrisiKvart/{idk}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult obrisiKvart([FromRoute] string idk)
        {
            try
            {
                DTOmanager.obrisiKvart(Convert.ToInt32(idk));
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("vratiSveNekretnineKvarta/{idk}")]//RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult vratiSveNekretnineKvarta([FromRoute] string idk)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiSveNekretnineKvarta(Convert.ToInt32(idk)));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

    }
}