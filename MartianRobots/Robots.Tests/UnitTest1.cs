using System;
using Xunit;

namespace Robots.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Planet uno = new Planet(4,3);
            string result = uno.printPlanet();

            Assert.Matches(result, "3 3");
        }
    }
}
