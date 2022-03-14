using System;
class electricityBill
{
public static void Main()
{
int unit,res1,res2,res3,res4;
Console.WriteLine("enter no of units");
unit=Convert.ToInt32(Console.ReadLine());

if(unit>0 && unit<=200)
  {
   res1=unit*2;
   Console.WriteLine("bill amount is:"+res1);
   res1=Convert.ToInt32(Console.ReadLine());

   }
else if(unit>=201 && unit<=350)
{
  res2=200*2+(unit-200)*3;
 Console.WriteLine("bill amount is:"+res2);
 res2=Convert.ToInt32(Console.ReadLine());
}

else if(unit>=351 && unit<=500)
{
res3=200*2+150*3+(unit-350)*5;
Console.WriteLine("bill amount is:"+res3);
 res3=Convert.ToInt32(Console.ReadLine());
}

else 
{
res4=200*2+150*3+150*5+(unit-500)*7;
Console.WriteLine("bill amount is:"+res4);
 res4=Convert.ToInt32(Console.ReadLine());
}

}
}