using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperSCISSOR;

namespace TestRockPaperScissor.UnitTests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void checkRoundWinner_player1Wins_returnsTrue()
        {
            // Act
            var result1 = Game.checkRoundWinner((int)TurnType.ROCK, (int)TurnType.SCISSOR);
            var result2 = Game.checkRoundWinner((int)TurnType.PAPER, (int)TurnType.ROCK);
            var result3 = Game.checkRoundWinner((int)TurnType.SCISSOR, (int)TurnType.PAPER);

            // Assert
            Assert.AreEqual(result1, true);
            Assert.AreEqual(result2, true);
            Assert.AreEqual(result3, true);
        }

        [TestMethod]
        public void checkRoundWinner_player1Loses_returnsFalse()
        {
            // Act
            var result1 = Game.checkRoundWinner((int)TurnType.ROCK, (int)TurnType.PAPER);
            var result2 = Game.checkRoundWinner((int)TurnType.PAPER, (int)TurnType.SCISSOR);
            var result3 = Game.checkRoundWinner((int)TurnType.SCISSOR, (int)TurnType.ROCK);

            // Assert
            Assert.AreEqual(result1, false);
            Assert.AreEqual(result2, false);
            Assert.AreEqual(result3, false);
        }
    }
}
