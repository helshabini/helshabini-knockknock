using System;
using Xunit;
using helshabini_knockknock.Controllers;

namespace helshabini_knockknock.Test
{
    public class TriangleTypeTest
    {
        [Fact]
        public void LenghtsMustBeNotZero()
        {
            TriangleTypeController sut = new TriangleTypeController();
            Assert.Equal("Error", sut.Get(0, 0, 0));
        }

        [Fact]
        public void LenghtsMustBeValid()
        {
            TriangleTypeController sut = new TriangleTypeController();
            Assert.Equal("Error", sut.Get(1, 2, 5));
            Assert.Equal("Error", sut.Get(1, 5, 2));
            Assert.Equal("Error", sut.Get(5, 1, 2));
        }

        [Fact]
        public void CanHandleBounds()
        {
            TriangleTypeController sut = new TriangleTypeController();
            int length = int.MaxValue;
            Assert.NotEqual("Error", sut.Get(length, length, length));
        }

        [Fact]
        public void TriangleIsEquilateral()
        {
            TriangleTypeController sut = new TriangleTypeController();
            int length = new Random().Next();
            Assert.Equal("Equilateral", sut.Get(length, length, length));
        }

        [Fact]
        public void TriangleIsIsosceles()
        {
            TriangleTypeController sut = new TriangleTypeController();
            Assert.Equal("Isosceles", sut.Get(10, 10, 15));
            Assert.Equal("Isosceles", sut.Get(15, 10, 10));
            Assert.Equal("Isosceles", sut.Get(10, 15, 15));
        }

        [Fact]
        public void TriangleIsScalene()
        {
            TriangleTypeController sut = new TriangleTypeController();
            int length = new Random().Next();
            Assert.Equal("Scalene", sut.Get(10, 11, 12));
            Assert.Equal("Scalene", sut.Get(10, 12, 11));
            Assert.Equal("Scalene", sut.Get(11, 10, 12));
            Assert.Equal("Scalene", sut.Get(11, 12, 10));
            Assert.Equal("Scalene", sut.Get(12, 11, 10));
            Assert.Equal("Scalene", sut.Get(12, 10, 11));
        }
    }
}
