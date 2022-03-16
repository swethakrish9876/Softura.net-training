using System;
class addandsub
{
public void add()
{
int num1,num2;
Console.WriteLine("Addition");
num1=45;
num2=54;

Console.WriteLine(num1+num2);
}

public void sub()
{
int num1,num2;
Console.WriteLine("Subtraction");
num1=55;
num2=54;

Console.WriteLine(num1-num2);
}



class mulanddiv:addandsub
{
public void mul()
{
int num1,num2;
Console.WriteLine("Multiplication");
num1=5;
num2=4;

Console.WriteLine(num1*num2);
}

public void div()
{
int num1,num2;
Console.WriteLine("Division");
num1=10;
num2=2;

Console.WriteLine(num1/num2);
}

public static void Main()
{
mulanddiv nobj=new mulanddiv();
nobj.add();
nobj.sub();
nobj.mul();
nobj.div();
}
}
}
