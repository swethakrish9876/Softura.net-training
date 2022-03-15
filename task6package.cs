using System;
class task6package
{
public static void Main()
{
string package;
Console.WriteLine("TV CHANNEL PACKAGE");
Console.WriteLine("select package");
package=Console.ReadLine();

switch(package)
{
case "package A":Console.WriteLine("Sounth special"+"\n"+"Children's club"+"\n"+"Movies"+"\n"+" cost Rs.250");
       break;
case "package B":Console.WriteLine("News"+"\n"+"sports"+"\n"+"Movies"+"\n"+"Regional-2"+"\n"+"cost Rs.450");
       break;
case "package C":Console.WriteLine("Discovery"+"\n"+"History"+"\n"+"National"+"\n"+"cost Rs.350");
       break;
default:Console.WriteLine("invalid package");
       break;
}

}
}