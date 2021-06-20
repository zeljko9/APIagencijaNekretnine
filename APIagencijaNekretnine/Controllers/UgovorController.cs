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
    public class UgovorController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiKupoprodajneUgovore")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSveKPUgovore()
        {
            try
            {
                return new JsonResult(DTOmanager.vratiKPugovore());
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiIznajmljivanjeUgovore")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSveIZNUgovore()
        {
            try
            {
                return new JsonResult(DTOmanager.vratiIZNugovore());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajKupoprodajniUgovor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult DodajKPUgovor([FromBody]JObject data)
        {
            var jmbgKupca = data["jmbgKupca"].ToObject<string>();
            var ulicaBroj = data["ulicaBroj"].ToObject<string>();
            var jmbgProdavca = data["jmbgProdavca"].ToObject<string>();

            try
            {
                DTOmanager.dodajKPugovor(jmbgKupca, ulicaBroj, jmbgProdavca);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }


        }

        [HttpPost]
        [Route("DodajIznajmljivanjeUgovor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult DodajIZNUgovor([FromBody] JObject data)
        {
            var jmbgKupca = data["jmbgKupca"].ToObject<string>();
            var ulicaBroj = data["ulicaBroj"].ToObject<string>();
            var jmbgProdavca = data["jmbgProdavca"].ToObject<string>();
            var datum = data["datum"].ToObject<DateTime>();

            try
            {
                DTOmanager.dodajIZNugovor(jmbgKupca, ulicaBroj, jmbgProdavca,datum);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }


        }


        [HttpDelete]
        [Route("ObrisiKPUgovor/{ulica}/{broj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult ObrisiKPUgovor(string ulica, string broj)
        {
            try
            {
                DTOmanager.obrisiKP(ulica, broj);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiIZNUgovor/{ulica}/{broj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult ObrisiIZNUgovor(string ulica, string broj)
        {
            try
            {
                DTOmanager.obrisiIZN(ulica, broj);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }






    }
}
