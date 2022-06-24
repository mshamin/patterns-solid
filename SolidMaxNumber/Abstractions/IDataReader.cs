using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidMaxNumber.Abstractions
{
    public interface IDataReader
    {
        public int Read();
        public string ReadLine();
    }
}
