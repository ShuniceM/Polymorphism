class Program
{
    static void Main(string[] args)
    {
        AddingIntegers objAddingIntegers = new AddingIntegers();
        int retval = objAddingIntegers.CalculatingNumbers(1, 2);
        Console.WriteLine(retval);
    }
}

public class AddingIntegers : AddingIntegersBase
//One name with different forms
{
    public virtual int CalculatingNumbers(int a, int b) //parameters= values that are passed in the object
    {
        return a + b; //int/string/bool methods= returns a value
    }
}

public class AddingNumerics : AddingIntegers
{
    public override int CalculatingNumbers(int a, int b)
    {
        int val = CalculatingNumbers(a, b);
        Console.WriteLine(val);
        return (a * b);

    }

}

public class SubtractingNumbers:AddingIntegers
{

}