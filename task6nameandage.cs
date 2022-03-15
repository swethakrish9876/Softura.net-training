using System;
class nameandage
{
public static void Main()
{
string name;
int age,i;
Console.WriteLine("enter name");
name=Console.ReadLine();
Console.WriteLine("enter age");
age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(age);
for(i=0;i<age;i++)
{
  Console.WriteLine(name);
}
}
}