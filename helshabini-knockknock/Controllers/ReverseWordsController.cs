using System;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace helshabini_knockknock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseWordsController : Controller
    {
        [HttpGet]
        public string Get(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return string.Empty;

                string[] words = sentence.Split(' ');
                string[] reversedWords = new string[words.Length];
                for (int i = 0; i < words.Length; i++)
                {
                    reversedWords[i] = Reverse(words[i]) + " ";
                }

            return string.Concat(reversedWords).Remove(sentence.Length);
        }

        public static string Reverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
