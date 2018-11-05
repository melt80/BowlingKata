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
        private FrameFactory _factory = new ConcreteFrameFactory();
      
        [TestMethod]
        public void AGameOfAllGutterBallsEqualsZero()
        {

            IFrame frame = _factory.MakeFrame(new int[] { 0, 0 });
            Game game = new Game(new List<IFrame> {frame});
            Assert.AreEqual(0, game.ScoreGame());

        }

        [TestMethod]
        public void AGameWithASpareAndAllGuttersEquals10()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 0, 0 });
            Game game = new Game(new List<IFrame>
                { frame, frame2 });
            Assert.AreEqual(10, game.ScoreGame());
        }

        [TestMethod]
        public void ASpareIntheFirstFollowedByAFiveAndAllGuttersEquals20()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 5, 0 });
            Game game = new Game(new List<IFrame>
                { frame, frame2 });
            Assert.AreEqual(20, game.ScoreGame());
        }

        [TestMethod]
        public void TwoSparesFollowedByAFiveAndAllGuttersEquals35()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 5, 5 });
            IFrame frame3 = _factory.MakeFrame(new int[] { 5, 0 });
            Game game = new Game(new List<IFrame>
                { frame, frame2, frame3});
            Assert.AreEqual(35, game.ScoreGame());
        }

        [TestMethod]
        public void SpareInLastWithBonusBall()
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
            Assert.AreEqual(150, game.ScoreGame() );
        }

        [TestMethod]
        public void StrikeInFirstGuttersRest()
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
            Assert.AreEqual(10, game.ScoreGame());

        }

        [TestMethod]
        public void StrikeWithTwoBallBonusGuttersRest()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 10 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 5, 4 });
            
            Game game = new Game(new List<IFrame>
                { frame, frame2 });
            Assert.AreEqual(28, game.ScoreGame());
        }

        [TestMethod]
        public void ThreeConsecutiveStrikesWithTwoBallBonusGuttersRest()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 10 });
            IFrame frame2 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame3 = _factory.MakeFrame(new int[] { 10 });
            IFrame frame4 = _factory.MakeFrame(new int[] { 5, 4 });
           
            Game game = new Game(new List<IFrame>
                { frame, frame2, frame3, frame4 });
            Assert.AreEqual(83, game.ScoreGame());

        }

        [TestMethod]
        public void ThreeStrikesLastFrameGuttersRest()
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
            Assert.AreEqual(30, game.ScoreGame());

        }

        [TestMethod]
        public void PerfectGame()
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
            Assert.AreEqual(300, game.ScoreGame());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MoreThanTenPinsShouldThrowAnException()
        {
            IFrame frame = _factory.MakeFrame(new int[] { 5, 6 });

            Game game = new Game(new List<IFrame>
                { frame });
            Assert.AreEqual(11, game.ScoreGame());
        }

    }
}
