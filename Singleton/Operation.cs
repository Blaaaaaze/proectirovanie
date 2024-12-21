using System;

class Operation
{
    public static double Run(char OperationCode, int operand)
    {
        Log lg2 = Log.MyLog;
        double rez = 0;
        switch (OperationCode)
        {
            case '+':
                rez += operand;
                lg2.LogExecution("Сложение " + operand);
                break;
            case '-':
                rez -= operand;
                lg2.LogExecution("Вычитание " + operand);
                break;
            case '*':
                rez *= operand;
                break;
            case '/':
                rez /= operand;
                break;
        }
        return rez;
    }
}
