// A set of tasks for revising GCSE computer science
using System;
using System.IO;
namespace Main
{
  using Loops;
  using Exta;
  using verification;
  class MainCode
   {
     
     public static void Main ()
     {
       whileloop.loop1();
       Console.WriteLine("What is your name");
       whileloop.nameloop((Console.ReadLine()));
       Extra.Text();
       Console.WriteLine("Enter your username, then press enter, then password, then enter");
       string[] data = {Console.ReadLine(),Console.ReadLine()};
       simplepassword.store(data);
       Console.WriteLine("Enter your username, then press enter, then password, then enter");
       string[] data2 = {Console.ReadLine(),Console.ReadLine()};
       simplepassword.checker(data2);
       
     }
   }
}
namespace Loops //This is a name space which can be referd to later, the namespace cant be a keyword
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
}
namespace Exta
{
  class Extra
  {
    public static void Text()
    {
      Console.WriteLine("Test");
    }
  }
  
}
namespace verification
{
  class simplepassword
  
  {
    public static void store(string[] args)
    {
      File.WriteAllLines("sample.txt",args);
    }
    public static void checker(string[] args)
    {
      string u = File.ReadAllLines("sample.txt")[0];
      string p =File.ReadAllLines("sample.txt")[1];
      if(args[0] == u & args[1] == p)
      {
        Console.WriteLine("Susess");
      }
      else
      {
        Console.WriteLine("Falure");
      }
    }
  }
  
}
