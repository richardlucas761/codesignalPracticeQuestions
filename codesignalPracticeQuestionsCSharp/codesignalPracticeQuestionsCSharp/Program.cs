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
            var integers = new List<int>();
            var output = new List<string>();

            foreach (var query in queries)
            {
                var operation = query[0];
                var parameter = query[1];

                var parameterAsInt = int.Parse(parameter);

                if (operation == "ADD")
                {
                    integers.Add(parameterAsInt);
                    output.Add(string.Empty);
                }
                else if (operation == "EXISTS")
                {
                    // Adds "true" or "false"
                    output.Add(integers.Contains(parameterAsInt).ToString().ToLowerInvariant());
                }
            }

            return [.. output];
        }

        public static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}