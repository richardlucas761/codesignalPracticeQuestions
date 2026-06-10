namespace codesignalPracticeQuestionsCSharp
{
    public static class Program
    {
        public static int AddTwoDigits(int n)
        {
            int total = 0;

            foreach (var digit in n.ToString())
            {
                // See https://learn.microsoft.com/en-us/dotnet/api/system.char
                var result = char.GetNumericValue(digit);

                // GetNumericValue returns a double so we must cast to int
                total += (int)result;
            }

            return total;
        }

        public static string[] ProcessQueries(string[][] queries)
        {
            // TODO implement
            return [];
        }

        public static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}