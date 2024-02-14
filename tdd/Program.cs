namespace tdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Bowling
    {
        public static int Throw(List<int> throws)
        {
            var sum = 0;
            var lastRoundStrike = false;

            if (throws.Count == 0)
            {
                return sum;
            }

            for (int i = 0; i < throws.Count; i++)
            {
                //strike check
                if (throws[i] == 10 && (i % 2 == 0))
                {
                    sum += throws[i];
                    lastRoundStrike = true;
                    throws[i + 1] = throws[i + 1] * 2;
                    throws[i + 2] = throws[i + 2] * 2;
                    continue;
                }
                else
                {
                    lastRoundStrike = false;
                }

                //spare check
                if (i != 0 && (throws[i - 1] != 10) && ((throws[i] + throws[i - 1]) % 10) == 0 && !lastRoundStrike)
                {
                    sum += throws[i];
                    throws[i + 1] = throws[i + 1] * 2;
                    continue;
                }

                sum += throws[i];
            }

            return sum;
        }
    }

}