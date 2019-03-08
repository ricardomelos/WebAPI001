using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hello2019.Controllers
{
    public class DefaultController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }
        public string Get(int id)
        {
            var list = new List<string>
            {
                "Olá Ricardo",
                "Hello RIchard",
                "Salut Ricardo",
                "Ola que tal Ricardo"
            };

            return id > list.Count - 1 ? "Índice fora do range" : list[id];
        }
    }
}
