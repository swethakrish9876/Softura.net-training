using System;
abstract class arithmetic
{
public abstract void add();
public abstract void sub();
public abstract void mul();
public abstract void div();
}

class calculator:arithmetic
{
public override void add()
{
int n1,n2,add;
n1=50;
n2=5;
Console.WriteLine("ADDITION");
add=n1+n2;
Console.WriteLine("Addition is"+add);
}

public override void sub()
{
int n1,n2,sub;
n1=50;
n2=5;
Console.WriteLine("SUBTRACTION");
sub=n1-n2;
Console.WriteLine("Subtraction is"+sub);
}


public override void mul()
{
int n1,n2,mul;
n1=50;
n2=5;
Console.WriteLine("MULTIPLICATION");
mul=n1*n2;
Console.WriteLine("Multiplication is"+mul);
}


public override void div()
{
int n1,n2,div;
n1=50;
n2=5;
Console.WriteLine("DIVISION");
div=n1/n2;
Console.WriteLine("Division is"+div);
}
}

class operation
{
public static void Main()
{


calculator obj=new calculator();
obj.add();
obj.sub();
obj.mul();
obj.div();



}
}