using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection;

public class Maths
{
    private int _number1;
    private int _number2;

    public Maths(int number1, int number2)
    {
        _number1 = number1;
        _number2 = number2;
    }
    public int Add(int number1,  int number2)
    {
        return number1 + number2;
    }

    public int Multiplication(int number1, int number2)
    {
        return number1 * number2;
    }

    public int Add2()
    {
        return _number1 + _number2;
    }

    public int Multiplication2()
    {
        return _number1 * _number2;
    }

}
