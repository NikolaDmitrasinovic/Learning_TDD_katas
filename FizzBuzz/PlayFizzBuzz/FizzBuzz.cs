namespace PlayFizzBuzz
{
    public class FizzBuzz
    {
        public static string[] Play(int iterations)
        {
            string[] fizzBuzz = new string[iterations];
            int number = 1;

            for (int i = 0; i < iterations; i++)
            {
                if (Is3Multiplier(number))
                {
                    fizzBuzz[i] = "Fizz";
                }
                else
                {

                    fizzBuzz[i] = number.ToString();
                }

                number++;
            }

            return fizzBuzz;
        }

        private static bool Is3Multiplier(int number)
        {
            return number % 3 == 0;
        }
    }
}