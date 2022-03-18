using System;
class details
{
public void det()
{
Console.WriteLine("Enter Employee ID");
int ID=Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter Employee Name");
string Name=Console.ReadLine();

Console.WriteLine("Enter Employee Gender");
string Gender=Console.ReadLine();


Console.WriteLine("Enter Employee Years of Experience");
int Exp=Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Employee delails are:");
Console.WriteLine("Employee ID is:"+ID);
Console.WriteLine("Employee Name is:"+Name);
Console.WriteLine("Employee Gender is:"+Gender);
Console.WriteLine("Employee Years of Experience is:"+Exp);

}
}



class abcd:details
{

public void saleprod()
{
Console.WriteLine("enter employee dept");
string dept=Console.ReadLine();

if(dept=="Sales & Marketing")
{
Console.WriteLine("Enter Employee Salary");
int salary=Convert.ToInt32(Console.ReadLine());

int bonus=salary*(20/100);
Console.WriteLine("your salary with bonus is:"+(salary+bonus));
}
else if(dept=="production dept")
{
Console.WriteLine("Enter Employee Salary");
int salary=Convert.ToInt32(Console.ReadLine());

int bonus=salary*(10/100);
Console.WriteLine("your salary with bonus is:"+salary+bonus);
}
}
public static void Main()
{


abcd obj=new abcd();
obj.det();
obj.saleprod();
}
}




