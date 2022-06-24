using SolidMaxNumber.Implementations;

namespace SolidMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commandPrompt = new CommandPrompt();
            var gameMaster = new GameMaster(commandPrompt, commandPrompt);
            gameMaster.SelectGame();
        }
    }
}