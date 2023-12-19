using System.Text;

namespace PlayFizzBuzz
{
    public class FizzBuzz
    {
        public static string[] Play(int iterations)
        {
            int[] numbers = Enumerable.Range(1, iterations).ToArray();
            string[] fizzBuzz = new string[iterations];

            for (int i = 0; i < iterations; i++)
            {
                string fizzOrBuzz = FizzOrBuzz(numbers[i]);

                fizzBuzz[i] = fizzOrBuzz.Length > 0 ? fizzOrBuzz.ToString() : numbers[i].ToString();

            }

            return fizzBuzz;
        }

        private static string FizzOrBuzz(int number)
        {
            StringBuilder resultBuilder = new();

            resultBuilder.Append(Is3Multiplier(number) ? "Fizz" : "");
            resultBuilder.Append(Is5Multiplier(number) ? "Buzz" : "");

            return resultBuilder.ToString();
        }

        private static bool Is5Multiplier(int number)
        {
            return number % 5 == 0;
        }

        private static bool Is3Multiplier(int number)
        {
            return number % 3 == 0;
        }
    }
}