using System;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace helshabini_knockknock.Controllers
{
    [Route("[api/controller]")]
    public class TokenController : Controller
    {
        [HttpGet]
        public Guid Get()
        {
            return new Guid("08c144c5-bb4d-428e-acbc-61e60a287af3");
        }
    }
}