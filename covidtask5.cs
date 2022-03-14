using System;
class covid
{
public static void Main()
{
string history,temp,cough;

Console.WriteLine("do you have travel history for past 3 months?");
history=Console.ReadLine();
if(history=="yes")
{
Console.WriteLine("do you have high temperature?");
temp=Console.ReadLine();
if(temp=="yes")
{
Console.WriteLine("do you have cough?");
cough=Console.ReadLine();
if(cough=="yes")
{
Console.WriteLine("swab test");

}
else
{
Console.WriteLine("quarantine fever medicine");
}
}
else
{
Console.WriteLine("have hot water");
}
}
else
{
Console.WriteLine("14 days separate yourself");
}
}
}