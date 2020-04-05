using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissor;

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

        [TestMethod]
        public void checkRoundWinner_gameTies_returnsNull()
        {
            // Act
            var result1 = Game.checkRoundWinner((int)TurnType.ROCK, (int)TurnType.ROCK);
            var result2 = Game.checkRoundWinner((int)TurnType.PAPER, (int)TurnType.PAPER);
            var result3 = Game.checkRoundWinner((int)TurnType.SCISSOR, (int)TurnType.SCISSOR);

            // Assert
            Assert.AreEqual(result1, null);
            Assert.AreEqual(result2, null);
            Assert.AreEqual(result3, null);
        }
        
        [TestMethod]
        public void getWinnerPlayer_higherScoreWins_returnsHigherScorePlayer()
        {
            // Arrange

            Player player1 = new Player("Ahmad");
            Player player2 = new Player("Walid");
            Game game = new Game(100, player1, player2);

            game.playGame();

            var result = game.getWinnerPlayer();
            var winner = player1.score == player2.score ? null : player1.score > player2.score ? player1 : player2;

            // Assert
            Assert.AreEqual(result, winner);
        }
        
        [TestMethod]
        public void getLoserPlayer_lowerScoreWins_returnslowerScorePlayer()
        {
            // Arrange

            Player player1 = new Player("Ahmad");
            Player player2 = new Player("Walid");
            Game game = new Game(100, player1, player2);

            // Act
            game.playGame();

            var result = game.getLoserPlayer();
            var loser = player1.score == player2.score ? null : player1.score < player2.score ? player1 : player2;

            // Assert
            Assert.AreEqual(result,loser);
        }
    }
}
