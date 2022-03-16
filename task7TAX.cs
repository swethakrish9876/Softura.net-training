using System;
class VAT
{
public virtual void CalculateTax()
{
int num;
float VAT;
Console.WriteLine("enter num to calculate VAT");
num=Convert.ToInt32(Console.ReadLine());
VAT=(num*20)/100;
Console.WriteLine("VAT is"+VAT);
}
}


class GST:VAT
{
public override void CalculateTax()
{
int num;
float GST;
Console.WriteLine("enter num to calculate GST");
num=Convert.ToInt32(Console.ReadLine());
GST=(num*12)/100;
Console.WriteLine("GST is"+GST);
}
}
class TAX
{
public static void Main()
{
GST obj=new GST();
obj.CalculateTax();

VAT nobj=new VAT();
nobj.CalculateTax();
}
}
