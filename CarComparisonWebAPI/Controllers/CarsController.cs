using CarComparisonWebAPI.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarComparisonWebAPI.Controllers
{
    public class CarsController : ApiController
    {
        private ITracer trace;

        public CarsController(ITracer trace) : base()
        {
            this.trace = trace;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            trace.WriteTrace(System.Diagnostics.TraceLevel.Verbose, "{4F1C09C0-9EAD-43CD-8C83-9C0EDA50E587}", "Got a get request!");
            return new string[] { "Car1", "Car2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "car";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}