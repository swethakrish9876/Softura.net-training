using System;
class task6multiplication
{
public static void Main()
{
int num,i;
Console.WriteLine("enter number");
num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("entered number is:"+num);
for(i=1;i<21;i++)
{
  Console.WriteLine(num+"*"+i+"="+num*i);

}
}
}