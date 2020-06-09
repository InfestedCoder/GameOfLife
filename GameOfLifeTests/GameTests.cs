using Xunit;
using GameOfLife;

namespace GameOfLifeTests
{
    public class GameTests
    {
        private Game game = new Game();

        [Fact]
        public void LiveCellWithOneLiveNeighborDiesTest()
        {
            Assert.False(game.isAlive(true, 1));
        }

        [Fact]
        public void LiveCellWithTwoLiveNeighborsLivesTest()
        {
            Assert.True(game.isAlive(true, 2));
        }

        [Fact]
        public void LiveCellWithThreeLiveNeighborsLivesTest()
        {
            Assert.True(game.isAlive(true, 3));
        }

        [Fact]
        public void LiveCellWithFourLiveNeighborsDiesTest()
        {
            Assert.False(game.isAlive(true, 4));
        }

        [Fact]
        public void DeadCellWithThreeLiveNeighborsLivesTest()
        {
            Assert.True(game.isAlive(false, 3));
        }

        [Fact]
        public void DeadCellWithTwoLiveNeighborsStaysDeadTest()
        {
            Assert.False(game.isAlive(false, 2));
        }
    }
}
