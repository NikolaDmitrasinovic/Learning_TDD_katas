namespace PlayFizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For how many numbers would you like to paly(game starts at 1): ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                string[] playGame = FizzBuzz.Play(int.Abs(n));

                for (int i = 0; i < playGame.Length; i++)
                {
                    Console.WriteLine(playGame[i]);
                }
            }
            else
                Console.WriteLine("You just don't know how to listen!");
        }
    }
}
