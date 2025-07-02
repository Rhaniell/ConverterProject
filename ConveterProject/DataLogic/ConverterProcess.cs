
namespace DataLogic
{
    public class ConverterProcess
    {
        public static double preamount = 0.0;
        public static bool MetertoCm(int userInput, int conversionInput, double amountInput, double amount)
        {
            if (userInput == 1 && conversionInput == 1 && amountInput >= 0)
            {
                amount = amountInput * 100;
                preamount = amount;
                return true;
            }

            if (userInput == 1 && conversionInput == 2 && amountInput >= 0)
            {
                amount = amountInput * 0.001;
                preamount = amount;
                return true;
            }

            if (userInput == 1 && conversionInput == 3 && amountInput >= 0)
            {
                amount = amountInput * 39.37;
                preamount = amount;
                return true;
            }

            if (userInput == 1 && conversionInput == 4 && amountInput >= 0)
            {
                amount = amountInput * 3.28;
                preamount = amount;
                return true;
            }

            if (userInput == 2 && conversionInput == 1 && amountInput >= 0)
            {
                amount = amountInput * 3600;
                preamount = amount;
                return true;
            }

            if (userInput == 2 && conversionInput == 2 && amountInput >= 0)
            {
                amount = amountInput * 3600000;
                preamount = amount;
                return true;
            }

            if (userInput == 2 && conversionInput == 3 && amountInput >= 0)
            {
                amount = amountInput * 0.42;
                preamount = amount;
                return true;
            }

            if (userInput == 2 && conversionInput == 4 && amountInput >= 0)
            {
                amount = amountInput * 0.006;
                preamount = amount;
                return true;
            }

            if (userInput == 3 && conversionInput == 1 && amountInput >= 0)
            {
                amount = amountInput * 1000;
                preamount = amount;
                return true;
            }

            if (userInput == 3 && conversionInput == 2 && amountInput >= 0)
            {
                amount = amountInput * 0.001;
                preamount = amount;
                return true;
            }

            if (userInput == 3 && conversionInput == 3 && amountInput >= 0)
            {
                amount = amountInput * 2.205;
                preamount = amount;
                return true;
            }

            if (userInput == 4 && conversionInput == 1 && amountInput >= 0)
            {
                amount = amountInput + 273.15;
                preamount = amount;
                return true;
            }

            if (userInput == 4 && conversionInput == 2 && amountInput >= 0)
            {
                amount = amountInput - 273.15;
                preamount = amount;
                return true;
            }

            if (userInput == 5 && conversionInput == 1 && amountInput >= 0)
            {
                amount = amountInput * 1000000;
                preamount = amount;
                return true;
            }

            if (userInput == 5 && conversionInput == 2 && amountInput >= 0)
            {
                amount = amountInput * 0.001;
                preamount = amount;
                return true;
            }

            if (userInput == 5 && conversionInput == 3 && amountInput >= 0)
            {
                amount = amountInput * 0.000001;
                preamount = amount;
                return true;
            }
            return false;
        }    
    }
}
