using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_MOQ_ConsoleApp
{
    public class Calculator : ICalculator
    {
        private IUSD_INR_RateFeed _rateFeed;

        public Calculator(IUSD_INR_RateFeed RateFeed)
        {
            _rateFeed = RateFeed;
        }

        public int Add(int param1, int param2)
        {
            throw new NotImplementedException();
        }

        public int ConvertUSDtoINR(int amount)
        {
            return (_rateFeed.GetExchangeRate() * amount);
        }

        public int Divide(int param1, int param2)
        {
            throw new NotImplementedException();
        }

        public int Multiple(int param1, int param2)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int param1, int param2)
        {
            throw new NotImplementedException();
        }
    }
}
