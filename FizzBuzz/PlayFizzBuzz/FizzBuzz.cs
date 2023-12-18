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
                StringBuilder resultBuilder = new();

                resultBuilder.Append(Is3Multiplier(numbers[i]) ? "Fizz" : "");
                resultBuilder.Append(Is5Multiplier(numbers[i]) ? "Buzz" : "");

                fizzBuzz[i] = resultBuilder.Length > 0 ? resultBuilder.ToString() : numbers[i].ToString();

            }

            return fizzBuzz;
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