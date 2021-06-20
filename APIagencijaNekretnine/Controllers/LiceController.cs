using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgencijaNekretnine;
using Newtonsoft.Json.Linq;

namespace APIagencijaNekretnine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LiceController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSvaLica")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSvaLica()
        {
            try
            {
                return new JsonResult(DTOmanager.vratiSvaLica());

            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiVlasnika/idVlasnika")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVlasnika(int idVlasnika)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiVlasnikaKupca(idVlasnika));

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajFizickoLice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajFizickoLice([FromBody]LiceBasic l)
        {
            try
            {
                DTOmanager.dodajFizickoLice(l);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPravnoLice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajPravnoLice([FromBody] LiceBasic l)
        {
            try
            {
                DTOmanager.dodajPravnoLice(l);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajTelefonLicu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        /*
          public IActionResult DodajKPUgovor([FromBody]JObject data)
        {
            var jmbgKupca = data["jmbgKupca"].ToObject<string>();
            var ulicaBroj = data["ulicaBroj"].ToObject<string>();
            var jmbgProdavca = data["jmbgProdavca"].ToObject<string>();
         */

        public IActionResult DodajTelefonLicu([FromBody]JObject data )
        {
            var jmbg = data["jmbg"].ToObject<string>();
            LiceBasic l = new LiceBasic();
            l.JMBG_PIB = jmbg;
            var brTel = data["tel"].ToObject<string>();
            TelefonBasic t = new TelefonBasic();
            t.brTel = brTel;
            
            try
            {
                DTOmanager.dodajTelefonLicu(l, t);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniLice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult IzmeniLice([FromBody]LiceBasic l)
        {
            try
            {
                DTOmanager.izmeniLice(l);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiLice/idLica")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
         public IActionResult ObrisiLice(int idLica)
        {
            try
            {
                DTOmanager.obrisiLice(idLica);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }



    }
}
