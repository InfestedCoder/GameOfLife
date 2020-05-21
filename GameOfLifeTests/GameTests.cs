using Xunit;
using GameOfLife;

namespace GameOfLifeTests
{
    public class GameTests
    {
        private Game game = new Game();

        [Fact]
        public void isAliveTest()
        {
            Assert.False(game.isAlive());
        }
    }
}
