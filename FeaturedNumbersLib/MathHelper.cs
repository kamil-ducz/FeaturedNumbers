using System.Linq;

namespace FeaturedNumbers
{
    public class MathHelper
    {
        public static int GetNextFeaturedNumber(int value)
        {
            do
            {
                value++;
            }
            while (!ifOdd(value) || !ifDivideByThree(value) || !ifDifferentDigits(value));

            return value;
        }

        public static bool ifOdd(int value)
        {
            return (value % 2 == 1);
        }

        public static bool ifDivideByThree(int value)
        {
            return (value % 3 == 0);
        }

        public static bool ifDifferentDigits(int value)
        {
            string tabValue = value.ToString();

            return tabValue.Distinct().Count() == tabValue.Length;
        }
    }
}
