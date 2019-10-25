using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IMyInterface instance;

        public ValuesController(IMyInterface instance)
        {
            this.instance = instance ?? throw new ArgumentNullException(nameof(instance));
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { $"Instance injected: {instance != null}" };
        }
    }
}
