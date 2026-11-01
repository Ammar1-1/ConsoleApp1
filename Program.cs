using System;

//an edit grom the GITHUB

class clsCalculator
{

    private float _Result = 0;
    private float _LastNumber = 0;
    private string _LastOperation = "Clear";
    // private float _PreviousResult = 0;

    private bool IsZero(float Number)
    {
        return (Number == 0);
    }





    public void Add(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Adding";
        _Result += Number;
    }

    public void Substract(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Substracting";
        _Result -= Number;
    }

    public bool Divide(float Number)
    {

        bool Succeeded = true;
        _LastOperation = "Dividing";

        if (IsZero(Number))
        {
            _LastNumber = Number;
            _Result /= 1;
            Succeeded = false;
        }
        else
        {
            _LastNumber = Number;
            _Result /= Number;
        }


        return Succeeded;

    }

    public void Multiply(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Multiplying";
        _Result *= Number;
    }

    public float GetFinalResults()
    {
        return _Result;
    }

    public void Clear()
    {
        _LastNumber = 0;
        _LastOperation = "Clear";
        _Result = 0;
    }

    public void PrintResult()
    {
        //Console.WriteLine("Result After " + _LastOperation + " " + _LastNumber + " is : " + _Result + "\n");
        Console.WriteLine("Result After {0} {1} is : {2}", _LastOperation, _LastNumber, _Result);
    }



}





class Program
{

    static void Main()
    {

        clsCalculator Calculator1 = new clsCalculator();

        Calculator1.Clear();

        Calculator1.Add(10);
        Calculator1.PrintResult();

        Calculator1.Add(100);
        Calculator1.PrintResult();

        Calculator1.Substract(20);
        Calculator1.PrintResult();

        Calculator1.Divide(0);
        Calculator1.PrintResult();

        Calculator1.Divide(2);
        Calculator1.PrintResult();

        Calculator1.Multiply(3);
        Calculator1.PrintResult();

        Calculator1.Clear();
        Calculator1.PrintResult();


        Console.ReadLine();
    }

}



