using System;
class task6student
{
public static void Main()
{
string name;
int sum=0,i,percent;
int []marks=new int[5];
Console.WriteLine("enter name of student");
name=Console.ReadLine();
Console.WriteLine("enter marks of each subject");
for(i=0;i<5;i++)
{
  marks[i]=Convert.ToInt32(Console.ReadLine());
  sum=sum+marks[i];
}
Console.WriteLine(sum);
Console.WriteLine();
percent=sum/5;
Console.WriteLine("Total percentage is:"+percent+"%");
}
}