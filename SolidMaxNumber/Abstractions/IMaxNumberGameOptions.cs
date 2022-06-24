using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidMaxNumber.Abstractions
{
    public interface IMaxNumberGameOptions
    {
        public int GetMaxRounds();
        public int GetMinNumber();
        public int GetMaxNumber();
    }
}
