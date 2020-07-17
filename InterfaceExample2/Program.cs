using System;
using System.Text;

class Car : Engin
{
    string color;
    string name;
    string vendor;
    Engin aEngin;
    public Car() {
        color = "하양";
        name = "자동차";
        vendor = "람보르기니";
        aEngin = new Engin();
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[").Append(color).Append("]").Append(Environment.NewLine);
        sb.Append("[").Append(name).Append("]").Append(Environment.NewLine);
        sb.Append("[").Append(vendor).Append("]").Append(Environment.NewLine);
        sb.Append("{").Append(aEngin).Append("}").Append(Environment.NewLine);
        sb.Append("------------------------");
        return sb.ToString();
    } 
}

class Engin
{
    string name;
    string vendor;

    public Engin() 
    {
        name = "휘발류 V6";
        vendor = "비엔츠";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("엔진 ");
        sb.Append("[").Append(name).Append("] ");
        sb.Append("[").Append(vendor).Append("]");
        return sb.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car aCar = new Car();
        Console.WriteLine(aCar.Equals("test"));
        Console.WriteLine(aCar.GetHashCode());

        aCar = new Car();
        Console.WriteLine(aCar.GetHashCode());
        Console.WriteLine(aCar.GetType());
        Console.WriteLine(aCar.ToString());
        Console.WriteLine(aCar);
    }
}
