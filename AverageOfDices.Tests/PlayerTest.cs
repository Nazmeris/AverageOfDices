namespace AverageOfDices.Tests
{
    public class DiceTests
    {

        [Test]
        public void WhenPlayerCollectNewDice_ShouldReturnCorrectMinMaxAverageUsingCalculateStatistisc()
        {
            var player1m = new PlayerInMemory("UnitTest");

            //Arrange

            player1m.AddDice(20);
            player1m.AddDice(8);

            //Act

            var statistics1m = player1m.GetPlayerStatistics();

            //Assert

            Assert.That(statistics1m.Min, Is.EqualTo(8));
            Assert.That(statistics1m.Max, Is.EqualTo(20));
            Assert.That(statistics1m.Average, Is.EqualTo(14));
        }
    }
}