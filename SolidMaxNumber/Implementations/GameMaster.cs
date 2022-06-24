using SolidMaxNumber.Abstractions;
using SolidMaxNumber.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidMaxNumber.Implementations
{
    public class GameMaster : IGameMaster
    {
        private IDataReader _dataReader;
        private IDataWriter _dataWriter;

        public GameMaster(IDataReader dataReader
            , IDataWriter dataWriter)
        {
            _dataReader = dataReader;
            _dataWriter = dataWriter;
        }
        public void SelectGame()
        {
            PlayMaxNumberGame();
        }
        private void PlayMaxNumberGame()
        {
            _dataWriter.Write("Welcome to MaxNumber game!");
            var gameOptions = CreateMaxNumberGameConfiguration();
            _dataWriter.Write("\r\nThe game is about to start in 3..2..1\r\n");
            var gameResult = new MaxNumberGame(_dataReader, _dataWriter, gameOptions).PlayGame();
            if (gameResult)
            {
                _dataWriter.Write("You win");
            }
            else
            {
                _dataWriter.Write("You loose");
            }

            _dataWriter.Write("Do you want to play another MaxNumber game? (y,n)");
            if (_dataReader.ReadLine().ToLower() == "y")
            {
                PlayMaxNumberGame();
            }
        }

        private IMaxNumberGameOptions CreateMaxNumberGameConfiguration()
        {
            int maxRounds = GetGameRounds();
            int minNumber = GetMinBorder();
            int maxNumber = GetMaxBorder(minNumber);

            return new MaxNumberGameOptions(maxRounds, minNumber, maxNumber);
        }

        private int GetMaxBorder(int minNumber)
        {
            _dataWriter.Write("Please enter max border:");
            int maxNumber = _dataReader.Read();

            while (!InputValidator.MoreThan(maxNumber, minNumber) && !InputValidator.WithinRange(maxNumber, minNumber + 1, int.MaxValue))
            {
                if (!InputValidator.MoreThan(maxNumber, minNumber) && !InputValidator.WithinRange(maxNumber, minNumber + 1, int.MaxValue)) _dataWriter.Write($"Incorrect input, the number must be in range [{minNumber + 1}, {int.MaxValue}]");
                _dataWriter.Write("Please enter max border:");
                maxNumber = _dataReader.Read();
            }

            return maxNumber;
        }

        private int GetMinBorder()
        {
            _dataWriter.Write("Please enter min border:");
            int minNumber = _dataReader.Read();

            while (!InputValidator.WithinRange(minNumber, int.MinValue, int.MaxValue))
            {
                if (!InputValidator.WithinRange(minNumber, int.MinValue, int.MaxValue)) _dataWriter.Write($"Incorrect input, the number must be in range [{int.MinValue}, {int.MaxValue}]");
                _dataWriter.Write("Please enter min border:");
                minNumber = _dataReader.Read();
            }

            return minNumber;
        }

        private int GetGameRounds()
        {
            var gameRounds = 0;
            while (InputValidator.LessThan(gameRounds, 1) && !InputValidator.WithinRange(gameRounds, 1, int.MaxValue))
            {
                _dataWriter.Write("Please enter the number of game rounds:");
                gameRounds = _dataReader.Read();
                if (InputValidator.LessThan(gameRounds, 1)) _dataWriter.Write("Incorrect input, there must be at least one game round");
                if (!InputValidator.WithinRange(gameRounds, 0, int.MaxValue)) _dataWriter.Write($"Incorrect input, there should be no more than {int.MaxValue} rounds");
            }

            return gameRounds;
        }
    }
}
