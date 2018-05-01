// Demonstration of some simple loops that will be tested on.
using System;
namespace whileloop //This is a name space which can be referd to later, the namespace cant be a keyword
{
  class whileloop //A class builds a frame work of code that can be sued later in other classes without having to copy the code again. 
  {
    public static void loop1()
    {
    int x = 0;
    while( x < 10)
    {
      Console.WriteLine("The value of X is " + x);
      x++;
     }
    }
    public static void nameloop(string name)
    {
      if (name == "")
      {
        Console.WriteLine("You have no name");
        Console.WriteLine("Your name will be Darren");
      }
      
      while (name == "")
      {
        name = "Darren";
      }
      Console.WriteLine("Your name is " +name);
    }
   }
   class MainStuff
   {
     public static void Main ()
     {
       whileloop.loop1();
       Console.WriteLine("What is your name");
       whileloop.nameloop((Console.ReadLine()));
     }
   }
}
