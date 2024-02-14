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
            var firstRound = false;
            var frame = 0;
            var sum = 0;

            if (throws.Count == 0)
            {
                return sum;
            }

            for (int i = 0; i < throws.Count; i++)
            {
                firstRound = !firstRound;

                //strike check
                if (firstRound && (throws[i] % 10 == 0) && throws[i] != 0 && i < 10)
                {
                    sum += throws[i];
                    frame++;

                    //boundary check
                    if (i + 1 < throws.Count)
                    {
                        throws[i + 1] = throws[i + 1] * 2;
                    }
                    if (i + 2 < throws.Count && i < 10)
                    {
                        throws[i + 2] = throws[i + 2] * 2;
                    }
                    firstRound = false;
                    continue;
                }

                //spare check
                if (i < 10 && i != 0 && !firstRound && ((throws[i] + throws[i - 1]) % 10 == 0) && (throws[i] != 0))
                {
                    sum += throws[i];
                    //boundary check
                    if (i + 1 < throws.Count)
                    {
                        throws[i + 1] = throws[i + 1] * 2;
                    }
                    continue;
                }

                sum += throws[i];
            }

            return sum;
        }
    }

}