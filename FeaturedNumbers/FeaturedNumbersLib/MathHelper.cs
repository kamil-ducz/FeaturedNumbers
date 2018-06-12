using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturedNumbers
{
    public class MathHelper
    {
        public static int GetNextFeaturedNumber(int value)
        {
            while (!ifOdd(value) || !ifDivideByThree(value) || !ifDifferentDigits(value))
            {
                value++;
            }
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
            bool digitFlag = true;
            for (int i = 0; i<tabValue.Length; i++)
            {
                for(int j = i+1; j < tabValue.Length; j++)
                {
                    if (tabValue[i] == tabValue[j])
                    {
                        digitFlag = false;
                        return digitFlag;
                    }
                }
            }
            
            return true;
        }
    }
}
