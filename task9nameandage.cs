using System;
class level
{
string name;
int age;
public level()
{
Console.WriteLine("Enter name");
name=Console.ReadLine();
Console.WriteLine("Enter age");
age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("your name is"+name+"your age is"+age);
}

public level(string name,int age)
{
this.name=name;
this.age=age;
Console.WriteLine("Entered name and age is:");
}

public static void Main()
{
level obj=new level();


level obj1=new level("krish",25);
Console.WriteLine(obj1.name);
Console.WriteLine(obj1.age);
}
}