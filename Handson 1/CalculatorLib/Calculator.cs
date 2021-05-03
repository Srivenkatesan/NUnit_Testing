namespace CalculatorLib
{
    public class Calculator
    {
        public int Add(int firstNumber,int secondNumber)
        {
            if (firstNumber>0&&secondNumber>0)
            {
                return firstNumber + secondNumber;
            }
            else
            {
                return 0;
            }
        }
    }
}
