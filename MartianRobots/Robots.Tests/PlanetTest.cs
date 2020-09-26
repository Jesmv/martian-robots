using System;
using Xunit;


    public class PlanetTest
    {
        [Theory]
        [InlineData(4,3)]
        [InlineData(6,2)]
        [InlineData(1,8)]
        [InlineData(7,25)]
        public void Planet(int x, int y)
        {
            Planet marte = new Planet(x,y);
            string result = marte.printPlanet();

            Assert.Matches(result, (x + " " + y));
        }
    }

