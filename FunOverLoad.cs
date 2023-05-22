using System;
namespace OOPS.overload
{
class FunOverLoad
{
public string name;
//overloaded functions
public void setName(string last)
{
name = last;
}
public void setName(string first, string last)
{
name = first + " " + last;
}
public void setName(string first, string middle, string last)
{
name = first + " " + middle + " " + last;
}

public void displayName() 
{
    Console.WriteLine("Name = " + name);
}
}
}
