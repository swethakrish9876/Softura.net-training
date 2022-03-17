using System;
interface Membership 
{
void silver();
void gold();
void platinum();
}
class package:Membership
{
public void silver()
{
Console.WriteLine("SILVER");
Console.WriteLine("3 days accomodation at resort");
}

public void gold()
{
Console.WriteLine("GOLD");
Console.WriteLine("5 days accomodation at resort & 2 dinners on the house");
}


public void platinum()
{
Console.WriteLine("PLATINUM");
Console.WriteLine("7 days accomodation at resort & 5 dinners on the house");
}
}

class implement
{
public static void Main()
{
package obj=new package();
{
obj.silver();
obj.gold();
obj.platinum();
}
}
}