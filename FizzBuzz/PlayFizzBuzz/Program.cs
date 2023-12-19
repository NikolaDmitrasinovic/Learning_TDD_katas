namespace PlayFizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("For how many turns would you like to paly(game starts at 1): ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Please make sure you enterd a whole number: ");
            }

            Console.WriteLine("Play FizzBuzz:");

            string[] playGame = FizzBuzz.Play(int.Abs(n));

            for (int i = 0; i < playGame.Length; i++)
            {
                Console.WriteLine(playGame[i]);
            }
        }
    }
}
