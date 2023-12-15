
namespace ClassLibraryEvenOrOdd
{
    public class EvenOrOdd
    {
        public static string OddOrEven(int[] intsArray)
        {
            return intsArray.Sum() % 2 == 0 ? "even" : "odd";
        }
    }
}
