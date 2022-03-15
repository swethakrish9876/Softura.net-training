using System;
public class task6product
{
public static void Main()
{
string[][]product=new string[3][];
product[0]=new string[]{"Biscuit","Biscuit","Biscuit","Biscuit"};
product[1]=new string[]{"Chocolate","Chocolate","Chocolate","Chocolate","Chocolate"};
product[2]=new string[]{"Drinks","Drinks","Drinks","Drinks","Drinks","Drinks"};
for(int i=0;i<product.Length;i++)
{
	for(int j=0;j<product[i].Length;j++)
	Console.Write(product[i][j]+"\t");
	Console.WriteLine();


}
}
}