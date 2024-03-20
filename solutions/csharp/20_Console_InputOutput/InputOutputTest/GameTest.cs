namespace InputOutputTest
{
    public class GameTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        public void Init_InvalidRange(int min, int max)
        {
            //Act Assert
            Assert.Throws<ArgumentException>(() => new Game(min, max));
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("0")]
        [InlineData("a")]
        [InlineData(" ")]
        [InlineData("")]
        [InlineData(null)]
        public void InvalidInput(string guess)
        {
            //Arrange
            var game = new Game(min: 1, max: 100);

            //Act
            var response = game.GetResponse(guess);

            //Assert
            Assert.Equal(HotColdResponse.InvalidInput, response);
        }

        [Theory]
        [InlineData(0, HotColdResponse.InvalidInput)]
        [InlineData(1, HotColdResponse.Cold)]
        [InlineData(29, HotColdResponse.Cold)]
        [InlineData(30, HotColdResponse.Warm)]
        [InlineData(44, HotColdResponse.Warm)]
        [InlineData(45, HotColdResponse.Hot)]
        [InlineData(49, HotColdResponse.Hot)]
        [InlineData(50, HotColdResponse.Correct)]
        [InlineData(51, HotColdResponse.Hot)]
        [InlineData(55, HotColdResponse.Hot)]
        [InlineData(56, HotColdResponse.Warm)]
        [InlineData(70, HotColdResponse.Warm)]
        [InlineData(71, HotColdResponse.Cold)]
        [InlineData(100, HotColdResponse.Cold)]
        [InlineData(101, HotColdResponse.InvalidInput)]
        public void InitialResponse(int guess, HotColdResponse expectedResponse)
        {
            //Arrange
            var game = new Game(min: 1, max: 100, targetNumber: 50);

            //Act
            var response = game.GetResponse(guess.ToString());

            //Assert
            Assert.Equal(expectedResponse, response);
        }

        [Theory]
        [InlineData(1, 50, HotColdResponse.Correct)]
        [InlineData(50, 50, HotColdResponse.Correct)]
        [InlineData(1, 1, HotColdResponse.RepeatGuess)]
        [InlineData(49, 51, HotColdResponse.Hot)]
        [InlineData(44, 56, HotColdResponse.Warm)]
        [InlineData(29, 71, HotColdResponse.Cold)]
        [InlineData(49, 48, HotColdResponse.Colder)]
        [InlineData(1, 2, HotColdResponse.Warmer)]
        [InlineData(44, 45, HotColdResponse.WarmerGettingHot)]
        public void SubsequentResponse(int guess1, int guess2, HotColdResponse expectedResponse)
        {
            //Arrange
            var game = new Game(min: 1, max: 100, targetNumber: 50);
            _ = game.GetResponse(guess1.ToString());

            //Act
            var response = game.GetResponse(guess2.ToString());

            //Assert
            Assert.Equal(expectedResponse, response);
        }
    }
}