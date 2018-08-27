using System;
using Microsoft.AspNetCore.Mvc;

namespace helshabini_knockknock.Controllers
{
    [Route("[api/controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        [HttpGet]
        public ActionResult<long> Get(long n)
        {
            try
            {
                if (n < 0)
                {
                    return Fibonacci(Math.Abs(n)) * -1;
                }

                return Fibonacci(n);
            }
            catch (Exception)
            {
                return BadRequest("Cannot calculate nth number in series if n > 92 as it cannot fit within a 64 bit integer.");
            }
        }

        public static long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
                return n;

            long f1 = 0;
            long f2 = 1;
            long result = 0;


            for (int i = 2; i <= n; i++)
            {
                checked
                {
                    result = f1 + f2;
                }
                f1 = f2;
                f2 = result;
            }

            return result;
        }
    }
}
