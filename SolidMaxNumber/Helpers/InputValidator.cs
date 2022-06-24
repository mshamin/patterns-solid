using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidMaxNumber.Helpers
{
    public static class InputValidator
    {
        public static bool WithinRange(int input, int minValue, int maxValue)
        {
            return input <= maxValue && input >= minValue;
        }
        public static bool MoreThan(int input, int minValue)
        {
            return input > minValue;
        }
        public static bool LessThan(int input, int maxValue)
        {
            return input < maxValue;
        }
    }
}
