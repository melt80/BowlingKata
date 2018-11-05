using System;
using System.Collections.Generic;
using System.Linq;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BowlingGameTests
    {
        private FrameFactory _factory;

       [TestInitialize]
        //-- TestInit (Arrange)
        public void Arrange()
        {
            _factory = new ConcreteFrameFactory();
        }

    [TestMethod]
        public void BowlingGame_AllGutterBalls_Scores_Zero()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 0, 0 });
            Game game = new Game(new List<IFrame> {frame});

            var expected = 0;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BowlingGame_SpareAndAllGutters_Scores_Ten()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 0, 0 });
            Game game = new Game(new List<IFrame>
                { frame, frame2 });

            var expected = 10;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BowlingGame_SpareFollowedByAFiveAndAllGutters_Scores_20()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 5, 0 });
            Game game = new Game(new List<IFrame>
                { frame, frame2 });

            var expected = 20;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BowlingGame_TwoSparesFollowedByAFiveAndAllGutters_Scores_35()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame3 = _factory.MakeFrame(new int[] { 5, 0 });
            Game game = new Game(new List<IFrame>
                { frame, frame2, frame3});

            var expected = 35;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BowlingGame_SpareInLastWithBonusRollOfFive_Scores_150()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame3 = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame4 = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame5 = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame6 = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame7 = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame8 = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame9 = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame10 = _factory.MakeFrame(new int[] { 5, 5, 5 });
            Game game = new Game(new List<IFrame>
                { frame, frame2, frame3, frame4, frame5, frame6, frame7, frame8, frame9, frame10 });

            var expected = 150;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BowlingGame_StrikeInFirstGuttersRest_Scores_10()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 10 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame3 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame4 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame5 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame6 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame7 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame8 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame9 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame10 = _factory.MakeFrame(new int[] { 0, 0 });
            Game game = new Game(new List<IFrame>
                { frame, frame2, frame3, frame4, frame5, frame6, frame7, frame8, frame9, frame10 });

            var expected = 10;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BowlingGame_StrikeWithTwoBallBonusGuttersRest_Scores_28()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 10 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 5, 4 });
            
            Game game = new Game(new List<IFrame>
                { frame, frame2 });

            var expected = 28;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BowlingGames_ThreeConsecutiveStrikesWithTwoBallBonusGuttersRest_Scores_83()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 10 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame3 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame4 = _factory.MakeFrame(new int[] { 5, 4 });
           
            Game game = new Game(new List<IFrame>
                { frame, frame2, frame3, frame4 });

            var expected = 83;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BowlingGame_ThreeStrikesLastFrameGuttersRest_Scores_30()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame3 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame4 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame5 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame6 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame7 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame8 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame9 = _factory.MakeFrame(new int[] { 0, 0 });
            IFrame frame10 = _factory.MakeFrame(new int[] { 10, 10, 10 });
            Game game = new Game(new List<IFrame>
                { frame, frame2, frame3, frame4, frame5, frame6, frame7, frame8, frame9, frame10 });

            var expected = 30;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BowlingGame_PerfectGame_Scores_300()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 10 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame3 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame4 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame5 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame6 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame7 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame8 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame9 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame10 = _factory.MakeFrame(new int[] { 10, 10, 10 });
            Game game = new Game(new List<IFrame>
                { frame, frame2, frame3, frame4, frame5, frame6, frame7, frame8, frame9, frame10 });

            var expected = 300;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BowlingGame_MoreThanTenPins_ThrowsException()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 5, 6 });

            Game game = new Game(new List<IFrame>
                { frame });

            var expected = 11;
            var actual = game.ScoreGame();

            Assert.AreEqual(expected, actual);
        }

    }
}
