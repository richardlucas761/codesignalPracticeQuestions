using System.Linq;

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
                    // Adds "true" or "false" depending on whether the integer exists or not
                    output.Add(integers.Contains(parameterAsInt).ToString().ToLowerInvariant());
                }
                else if (operation == "REMOVE")
                {
                    // Adds "true" or "false" depending on whether the integer was removed once or not
                    output.Add(integers.Remove(parameterAsInt).ToString().ToLowerInvariant());
                }
                // TODO refactor GET_NEXT into a separate routine as the ProcessQueries method is getting
                // too large, difficult to specify sub routines in the Code Signal web based IDE so leaving this
                // as is.
                else if (operation == "GET_NEXT")
                {
                    // Return the minimal integer in the container that is strictly greater than the provided value.
                    // In case there is no such integer in the container, return empty string.

                    var greater = integers.OrderBy(x => x).FirstOrDefault(x => x > parameterAsInt);

                    // TODO: can't use this cleaner solution in .NET 9 which is what the Code Signal
                    // practice test uses.
                    // var greater = integers.Order().FirstOrDefault(x => x > parameterAsInt);

                    if (greater == 0)
                    {
                        output.Add(string.Empty);
                    }
                    else
                    {
                        output.Add(greater.ToString());
                    }
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