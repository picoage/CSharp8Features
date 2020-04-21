internal class Calculator{

internal int Calculate()
{
    int a = 10; 
    int b = 20; 
    int c= Sum(); 

    static int Sum() => a +b;

    return c; 
}

internal int CalculatorWithStatic(int a, int b)
{
    int c = Sum(a,b); 

   static int Sum(int a, int b) => a+b; 

    return c; 
}

}