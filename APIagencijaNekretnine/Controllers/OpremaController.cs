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
    public class OpremaController : ControllerBase
    {
        [HttpGet]
        [Route("vratiSvuOpremu/{idn}")]//RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult vratiSvuOpremu([FromRoute]string idn)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiSvuOpremu(Convert.ToInt32(idn)));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("izmeniOpremu")]//RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult izmeniOpremu([FromBody] Oprema o)
        {
            try
            {
                DTOmanager.izmeniOpremu(o);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("dodajOpremu")]//RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult dodajOpremu([FromBody] JObject o)
        {
            try
            {
                var oprema = o["OpremaBasic"].ToObject<OpremaBasic>();
                var nekretnina = o["NekretninaBasic"].ToObject<NekretninaBasic>();

                DTOmanager.dodajOpremu(oprema, nekretnina);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("obrisiOpremu/{ido}")]//RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult obrisiOpremu([FromRoute]string ido)
        {
            try
            {
                DTOmanager.obrisiOpremu(Convert.ToInt32(ido));

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("vratiOpremu/{ido}")]//RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult vratiOpremu([FromRoute]string ido)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiOpremu(Convert.ToInt32(ido)));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}