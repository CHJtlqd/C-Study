using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

delegate int CalcDelegate(int x, int y);
class MessageMap
{
    public char opCode;
    public CalcDelegate Calc;
    public MessageMap(char opCode, CalcDelegate Calc)
    {
        this.opCode = opCode;
        this.Calc = Calc;
    }
}

public class Mathematics
{
    CalcDelegate[] methods;
    MessageMap[] aMessageMap;

    static int Add(int x, int y) { return x + y; }
    static int Subtract(int x, int y) { return x - y; }
    static int Multiply(int x, int y) { return x * y; }
    static int Divide(int x, int y) { return x / y; }
    static int Per(int x, int y) { return x % y; }

    public Mathematics()
    {
        // static 메서드를 가리키는 델리게이트 배열 초기화
        methods = new CalcDelegate[] { Mathematics.Add, Mathematics.Subtract, Mathematics.Multiply, Mathematics.Divide ,Mathematics.Per};
        aMessageMap = new MessageMap[] {
            new MessageMap('+',Mathematics.Add),
            new MessageMap('-',Mathematics.Subtract),
            new MessageMap('*',Mathematics.Multiply),
            new MessageMap('/',Mathematics.Divide),
            new MessageMap('%',Mathematics.Per)
        };

    }
    // methods 배열에 담긴 델리게이트를 opCode 인자에 따라 호출
    public void Calculate(char opCode, int operand1, int operand2)
    {
        //switch (opCode)
        //{
        //    case '+':
        //        Console.WriteLine("+: " + methods[0](operand1, operand2));
        //        break;
        //    case '-':
        //        Console.WriteLine("-: " + methods[1](operand1, operand2));
        //        break;
        //    case '*':
        //        Console.WriteLine("*: " + methods[2](operand1, operand2));
        //        break;
        //    case '/':
        //        Console.WriteLine("/: " + methods[3](operand1, operand2));
        //        break;

        //}

        Console.Write(opCode + " : ");
        foreach (MessageMap Temp in aMessageMap)
        {
            if (Temp.opCode == opCode)
            {
                Console.WriteLine(Temp.Calc(operand1, operand2));
            }
        }
    }
}

namespace DelegateExample2
{

    class Program
    {
        //delegate void CarDelegate();
        //static void Car() {
        //	Console.WriteLine("메뚜기");

        //}
        // 3개의 매개변수를 받고 void를 반환하는 델리게이트 정의
        // 매개변수의 타입이 중요할 뿐 매개변수의 이름은 임의로 정할 수 있음
        delegate void WorkDelegate(char arg1, int arg2, int arg3);
        static void Main(string[] args)
        {
            //CarDelegate dealer;
            //dealer = Car;
            //dealer();
            //Car();
            Mathematics math = new Mathematics();
            WorkDelegate work = math.Calculate;
            work('+', 10, 5);
            work('-', 10, 5);
            work('*', 10, 5);
            work('/', 10, 5);

        }
    }
}