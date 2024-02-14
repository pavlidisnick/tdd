using tdd;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Return_NoThrow()
        {
            var expected = 0;
            var actuall = Bowling.Throw(new List<int> { });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SingleThrow()
        {
            var expected = 5;
            var actuall = Bowling.Throw(new List<int> { 5 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_TwoThrow()
        {
            var expected = 7;
            var actuall = Bowling.Throw(new List<int> { 5, 2 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpareThrow()
        {
            var expected = 14;
            var actuall = Bowling.Throw(new List<int> { 6, 4, 2 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpecialSpareCase()
        {
            var expected = 13;
            var actuall = Bowling.Throw(new List<int> { 0, 5, 5, 3 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_StrikeThrow()
        {
            var expected = 18;
            var actuall = Bowling.Throw(new List<int> { 10, 2, 2 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpecialStrikeThrow1()
        {
            var expected = 14;
            var actuall = Bowling.Throw(new List<int> { 0, 10, 1, 2 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpecialStrikeThrow2()
        {
            var expected = 26;
            var actuall = Bowling.Throw(new List<int> { 0, 10, 0, 10, 2, 2 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpecialStrikeThrow3()
        {
            var expected = 36;
            var actuall = Bowling.Throw(new List<int> { 10, 0, 10, 3 });

            Assert.AreEqual(expected, actuall);
        }
    }
}