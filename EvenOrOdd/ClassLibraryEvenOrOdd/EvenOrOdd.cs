
namespace ClassLibraryEvenOrOdd
{
    public class EvenOrOdd
    {
        public static string OddOrEven(int[] intsArray)
        {
            if (intsArray.Length == 0)
                return "even";

            return intsArray.Sum() % 2 == 0 ? "even" : "odd";
        }
    }
}
