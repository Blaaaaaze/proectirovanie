using System;

class ArithmeticUnit
{
    public double Register { get; set; }

    public void Run(char operationCode, double operand)
    {

        switch (operationCode) 
        { 
            case '+':
                Register += operand;
                break;
            case '-':
                Register -= operand;
                break;
            case '*':
                Register *= operand;
                break;
            case '/':
                Register /= operand;
                break;
        }
    }
}