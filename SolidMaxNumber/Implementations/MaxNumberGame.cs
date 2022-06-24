using SolidMaxNumber.Abstractions;
using SolidMaxNumber.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolidMaxNumber.Implementations
{
    public class MaxNumberGame : IGame
    {
        private int _resultNumber;
        private IDataReader _dataReader;
        private IDataWriter _dataWriter;
        private IMaxNumberGameOptions _gameOptions;

        public MaxNumberGame(IDataReader dataReader
            , IDataWriter dataWriter, IMaxNumberGameOptions gameOptions)
        {
            _dataReader = dataReader;
            _dataWriter = dataWriter;
            _gameOptions = gameOptions;
        }

        public bool PlayGame()
        {
            _resultNumber = new Random().Next(_gameOptions.GetMinNumber(), _gameOptions.GetMaxNumber());
            int userResult;
            int maxRounds = _gameOptions.GetMaxRounds();
            for (int i = 0; i < maxRounds; i++)
            {
                _dataWriter.Write("Please enter number:");
                userResult = _dataReader.Read();
                if (userResult < _resultNumber)
                {
                    _dataWriter.Write("Your number is less than mine");
                }
                else if (userResult > _resultNumber)
                {
                    _dataWriter.Write("Your number is bigger than mine");
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
