﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicSurveyRest.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DynamicSurveyRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveysController : ControllerBase
    {
        // GET: api/<SurveysController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SurveysController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SurveysController>
        [HttpPost]
        public void Post([FromBody] Survey value)
        {


        }

        // PUT api/<SurveysController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SurveysController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
