using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_MOQ_ConsoleApp
{
    public interface ICalculator
    {
        int Add(int param1, int param2);
        int Subtract(int param1, int param2);
        int Multiple(int param1, int param2);
        int Divide(int param1, int param2);

        int ConvertUSDtoINR(int amount);
    }

    public interface IUSD_INR_RateFeed
    {
        int GetExchangeRate();
    }
}
