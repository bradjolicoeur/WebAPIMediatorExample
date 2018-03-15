using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatorExample.Core.Widgets;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorExample.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IMediator Mediator { get; set; }
        public ValuesController(IMediator mediator)
        {
            Mediator = mediator;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<SaveWidgetResponse> Post([FromBody]SaveWidget value)
        {
            return await Mediator.Send(value); ;
        }

       
    }
}
