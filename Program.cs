using SolidMaxNumber.Implementations;

namespace SolidMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commandPrompt = new CommandPrompt();
            var game = new MaxNumberGame(commandPrompt, commandPrompt);
            var gameOptions = game.CreateGameConfiguration();
            game.PlayGame(gameOptions);
        }
    }
}