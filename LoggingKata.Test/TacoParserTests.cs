using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line).Location.Longitude;
            //Assert
            Assert.Equal(expected, actual);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.168176,-87.521815,Taco Bell Tuscaloosa...", 33.168176)]
        [InlineData("32.609135, -85.479907, Taco Bell Auburn...", 32.609135)]

        public void ShouldParseLatitude(string line, double expected)
        {
            var tacoParser = new TacoParser();

            var actual = tacoParser.Parse(line).Location.Latitude;
            Assert.Equal(expected, actual);
        }

    }
}
