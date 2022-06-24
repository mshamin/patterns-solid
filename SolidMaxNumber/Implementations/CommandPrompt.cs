using SolidMaxNumber.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidMaxNumber.Implementations
{
    internal class CommandPrompt : ICommandPrompt
    {
        public int Read()
        {
            return int.Parse(Console.ReadLine()??"");
        }
        public string ReadLine()
        {
            return Console.ReadLine() ?? "";
        }
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
