using System;
using Xunit;
using helshabini_knockknock.Controllers;

namespace helshabini_knockknock.Test
{
    public class TokenTest
    {
        [Fact]
        public void WillIssueCorrectToken()
        {
            TokenController sut = new TokenController();
            Assert.Equal("08c144c5-bb4d-428e-acbc-61e60a287af3", sut.Get().ToString());
        }
    }
}
