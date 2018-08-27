using System;
using Xunit;
using helshabini_knockknock.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace helshabini_knockknock.Test
{
    public class FibonacciTest
    {
        [Fact]
        public void CanHandleZero()
        {
            FibonacciController sut = new FibonacciController();
            Assert.Equal(0, sut.Get(0).Value);
        }

        [Fact]
        public void CanHandleOne()
        {
            FibonacciController sut = new FibonacciController();
            Assert.Equal(1, sut.Get(1).Value);
        }

        [Fact]
        public void CanHandlePositiveValues()
        {
            FibonacciController sut = new FibonacciController();
            Assert.Equal(7540113804746346429, sut.Get(92).Value);
        }

        [Fact]
        public void CanHandleNegativeValues()
        {
            FibonacciController sut = new FibonacciController();
            Assert.Equal(-7540113804746346429, sut.Get(-92).Value);
        }

        [Fact]
        public void CanHandleBounds()
        {
            FibonacciController sut = new FibonacciController();
            Assert.IsNotType<BadRequestObjectResult>(sut.Get(92).Result);
            Assert.IsType<BadRequestObjectResult>(sut.Get(93).Result);
        }
    }
}
