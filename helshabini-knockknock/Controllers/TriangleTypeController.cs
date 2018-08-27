using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace helshabini_knockknock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleTypeController : Controller
    {
        [HttpGet]
        public string Get(int a, int b, int c)
        {
            string result = "Error";

            if (!IsValidTriangle(a, b, c))
            {
                return result;
            }

            if (a == b && a == c)
            {
                result = "Equilateral";
            }
            else if (a == b || a == c || b == c)
            {
                result = "Isosceles";
            }
            else if (a != b && a != c && b != c)
            {
                result = "Scalene";
            }

            return result;
        }

        public static bool IsValidTriangle(int a, int b, int c)
        {
            try
            {
                return a > 0 && b > 0 && c > 0 && (long) a + b > c && (long) a + c > b && (long) b + c > a;
            }
            catch
            {
                return false;
            }
        }
    }
}
