﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult DodajTelefonLicu([FromBody] LiceBasic l, [FromBody]TelefonBasic t)
        {
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