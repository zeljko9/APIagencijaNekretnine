using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgencijaNekretnine;

namespace APIagencijaNekretnine.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PoslovnicaController : ControllerBase
    {
       
        [HttpGet]
        [Route("PreuzmiSvePoslovnice/")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSvePoslovnice()
        {
            try
            {
                return new JsonResult(DTOmanager.vratiSvePoslovnice());
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPoslovnicu/{idPoslovnice}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPoslovnicu(int idPoslovnice)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiPoslovnicu(idPoslovnice));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSveZaposlenePoslovnice/{idPoslovnice}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSveZaposlene(int idPoslovnice)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiZaposlenePoslovnice(idPoslovnice));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiProdavca/{jmbgProdavca}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetProdavca(string jmbgProdavca)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiProdavca(jmbgProdavca));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSveSefove/")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSveSefove()
        {
            try
            {
                return new JsonResult(DTOmanager.vratiSveSefove());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSefa/{jmbgSefa}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSefa(string jmbgSefa)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiSefa(jmbgSefa));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiAgenteProdavca/{jmbgProdavca}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAgenteProdavca(string jmbgProdavca)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiAgenteProdavca(jmbgProdavca));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


        [HttpGet]
        [Route("PreuzmiAgenta/{jmbgAgenta}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAgenta(string jmbgAgenta)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiAgenta(jmbgAgenta));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajProdavca/{idPoslovnice}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajPoslovnicu(int idPoslovnice ,[FromBody]ZaposleniBasic z)
        {
            try
            {
                var p = DTOmanager.vratiPoslovnicu(idPoslovnice);
                DTOmanager.dodajProdavca(z, p);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajSefa/{idPoslovnice}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajSefa(int idPoslovnice, [FromBody] ZaposleniBasic z)
        {
            try
            {
                var p = DTOmanager.vratiPoslovnicu(idPoslovnice);
                DTOmanager.dodajSefa(z, p);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPoslovnicu/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajPoslovnicu([FromBody]PoslovnicaBasic p)
        {
            try
            {
                DTOmanager.dodajPoslovnicu(p);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajAgenta/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajAgenta([FromBody] AgentBasic a)
        {
            try
            {
                DTOmanager.dodajAgenta(a);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniPoslovnicu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniPoslovnicu([FromBody] PoslovnicaBasic p)
        {
            try
            {
                DTOmanager.izmeniPoslovnicu(p);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniProdavca")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniProdavca([FromBody] ProdavacBasic p)
        {
            try
            {
                DTOmanager.izmeniProdavca(p);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniAgenta")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniAgenta([FromBody] AgentBasic a)
        {
            try
            {
                DTOmanager.izmeniAgenta(a);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiPoslovnicu/{idPoslovnice}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiPoslovnicu(int idPoslovnice)
        {
            try
            {
                DTOmanager.obrisiPoslovnicu(idPoslovnice);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiZaposlenog/{jmbgZaposlenog}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiZaposlenog(string jmbgZaposlenog)
        {
            try
            {
                DTOmanager.obrisiProdavca(jmbgZaposlenog);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiAgenta/{idAgenta}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiAgenta(int idAgenta)
        {
            try
            {
                DTOmanager.obrisiAgenta(idAgenta);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }













    }
}
