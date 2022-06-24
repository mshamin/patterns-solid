using SolidMaxNumber.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidMaxNumber.Implementations
{
    public class MaxNumberGameOptions : IMaxNumberGameOptions
    {
        private int _maxRounds;
        private int _minNumber;
        private int _maxNumber;

        public MaxNumberGameOptions (int maxRounds, int minNumber, int maxNumber)
        {
            _maxRounds = maxRounds;
            _minNumber = minNumber;
            _maxNumber = maxNumber;
        }

        public int GetMaxRounds()
        {
            return _maxRounds;
        }

        public int GetMinNumber()
        {
            return _minNumber;
        }

        public int GetMaxNumber()
        {
            return _maxNumber;
        }
    }
}
