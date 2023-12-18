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
                if (number % 3 == 0)
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
    }
}