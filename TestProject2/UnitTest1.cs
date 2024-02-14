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
        public void Return_Spare()
        {
            var expected = 14;
            var actuall = Bowling.Throw(new List<int> { 6, 4, 2 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpecialSpare1()
        {
            var expected = 13;
            var actuall = Bowling.Throw(new List<int> { 0, 5, 5, 3 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpecialSpare2()
        {
            var expected = 26;
            var actuall = Bowling.Throw(new List<int> { 0, 10, 0, 10, 2, 2 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpecialSpare3()
        {
            var expected = 14;
            var actuall = Bowling.Throw(new List<int> { 0, 10, 1, 2 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_Strike()
        {
            var expected = 18;
            var actuall = Bowling.Throw(new List<int> { 10, 2, 2 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpecialCase1()
        {
            var expected = 36;
            var actuall = Bowling.Throw(new List<int> { 10, 0, 10, 3 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpecialCase2()
        {
            var expected = 38;
            var actuall = Bowling.Throw(new List<int> { 10, 0, 10, 3, 2 });

            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        public void Return_SpecialCase3()
        {
            var expected = 300;
            var actuall = Bowling.Throw(new List<int> { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });

            Assert.AreEqual(expected, actuall);
        }
    }
}