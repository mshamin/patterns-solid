using SolidMaxNumber.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidMaxNumber.Implementations
{
    public class MaxNumberGame
    {
        private int _resultNumber;
        private IDataReader _dataReader;
        private IDataWriter _dataWriter;

        public MaxNumberGame(IDataReader dataReader
            ,IDataWriter dataWriter)
        {
            _dataReader = dataReader;
            _dataWriter = dataWriter;
        }
        public GameOptions CreateGameConfiguration()
        {
            _dataWriter.Write("Welcome to MaxNumber game!");
            _dataWriter.Write("Please enter the number of game rounds:");
            var maxRounds = _dataReader.Read();
            _dataWriter.Write("Please enter min border:");
            var minNumber = _dataReader.Read();
            _dataWriter.Write("Please enter max border:");
            var maxNumber = _dataReader.Read();
            return new GameOptions(maxRounds, minNumber, maxNumber);
        }
        public bool PlayGame(IGameOptions gameOptions)
        {
            _dataWriter.Write("\r\nThe game is about to start in 3..2..1\r\n");
            _resultNumber = new Random().Next(gameOptions.GetMinNumber(), gameOptions.GetMaxNumber());
            int userResult;
            int maxRounds = gameOptions.GetMaxRounds();
            for (int i = 0; i < maxRounds; i++)
            {
                _dataWriter.Write("Please enter number:");
                userResult = _dataReader.Read();
                if (userResult < _resultNumber)
                {
                    _dataWriter.Write("Your number is less than mine");
                } else if (userResult > _resultNumber)
                {
                    _dataWriter.Write("Your number is bigger than mine");
                } else
                {
                    _dataWriter.Write("You win");
                    return true;
                }
            }
            _dataWriter.Write("You loose");
            return false;
        }
    }
}
