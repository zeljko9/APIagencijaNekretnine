using AgencijaNekretnine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace APIagencijaNekretnine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NekretninaController : ControllerBase
    {
        [HttpGet]
        [Route("vratiSveNekretnine")] //RADI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult vratiSveNekretnine() {
            try
            {
                return new JsonResult(DTOmanager.vratiSveNekretnine());
            }
            catch (Exception e) {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("dodajStambenuNekretninu")] //RADI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult dodajStambenuNekretninu([FromBody] NekretninaBasic nb) {
            try
            {
                DTOmanager.dodajStambenuNekretninu(nb);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("dodajPoslovnuNekretninu")] //RADI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult dodajPoslovnuNekretninu([FromBody] NekretninaBasic nb)
        {
            try
            {
                DTOmanager.dodajPoslovnuNekretninu(nb);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("izmeniNekretninu")]//RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult izmeniNekretninu([FromBody] NekretninaBasic nb)
        {
            try
            {
                DTOmanager.izmeniNekretninu(nb);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        /* public IActionResult DodajKPUgovor([FromBody]JObject data)
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


        }*/


        [HttpPost]
        [Route("dodajOpremu")]//RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult dodajOpremu([FromBody] JObject data)
        {
            var IDNekretnina = data["IDNekretnina"].ToObject<int>();
            var Naziv = data["Naziv"].ToObject<string>();


            try
            {
                NekretninaBasic nek = DTOmanager.vratiNekretninu(IDNekretnina);
                OpremaBasic oprema = new OpremaBasic();
                oprema.NazivOpreme = Naziv;
                oprema.pripadaNekretnini = nek;
                DTOmanager.dodajOpremu(oprema, nek);
                return Ok();
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
        public IActionResult izmeniOpremu([FromBody] OpremaBasic ob)
        {
            try
            {
                DTOmanager.izmeniOpremu(ob);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        

        [HttpGet]
        [Route("vratiNekretninu/{idn}")] //RADI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult vratiSveNekretnine([FromRoute]string idn)
        {
            try
            {
                return new JsonResult(DTOmanager.vratiNekretninu(Convert.ToInt32(idn)));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("obrisiNekretninu/{idn}")]//RADII
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult obrisiNekretninu([FromRoute]string idn)
        {
            try
            {
                DTOmanager.obrisiNekretninu(Convert.ToInt32(idn));
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }
}

          
