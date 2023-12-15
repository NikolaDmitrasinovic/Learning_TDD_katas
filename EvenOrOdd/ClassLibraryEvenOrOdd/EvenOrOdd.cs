
namespace ClassLibraryEvenOrOdd
{
    public class EvenOrOdd
    {
        public static string OddOrEven(int[] intsArray)
        {
            if (intsArray.Length != 0)
            {
                return "odd";
            }

            return "even";
        }
    }
}
