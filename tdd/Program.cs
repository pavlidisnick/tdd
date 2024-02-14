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
            var strikeBonus = 0;

            if (throws.Count == 0)
            {
                return sum;
            }

            for (int i = 0; i < throws.Count; i++)
            {
                if (throws.Count > 2 && i == throws.Count - 1)
                {
                    sum += throws[i]*2;
                    break;
                }

                //if (throws[i] == 10)
                //{
                //    strikeBonus += 2;
                //}

                sum += throws[i];
            }

            return sum;
        }
    }

}