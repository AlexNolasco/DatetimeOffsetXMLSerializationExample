using SO35990798.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace SO35990798.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Foo> Get()
        {
            return new Foo[] {
                new Foo() {
                    Id = Guid.NewGuid(),
                    AcquireDate = DateTimeOffset.Now
                }
            };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
