using tdd;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public int TestMethod1()
        {
            var result = Bowling.Throw(5);
            return result;
        }
    }
}