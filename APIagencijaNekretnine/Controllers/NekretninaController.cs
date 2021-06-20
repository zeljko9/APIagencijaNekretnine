﻿using AgencijaNekretnine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
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
        [Route("vratiSveNekretnine")]
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
        [Route("dodajStambenuNekretninu")]
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
        [Route("dodajPoslovnuNekretninu")]
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
        [Route("izmeniNekretninu")]
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

        [HttpPut]
        [Route("izmeniOpremu")]
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
        [Route("vratiNekretninu/{idn}")]
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
        [Route("obrisiNekretninu/{idn}")]
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


/*
            try
            {

            }
            catch (Exception e) {
                return BadRequest(e.ToString());
            }
 */
