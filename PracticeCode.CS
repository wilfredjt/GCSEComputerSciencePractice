// Demonstration of some simple loops that will be tested on.
using System;
using System.IO;
namespace Main
{
  using Loops;
  using Exta;
  using verification;
  using arrays;
  using sorting;
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
       array.array1d();
       sort.linear();
       
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
namespace arrays
{
  class array
  {
    public static void array1d()
    {
      string[] animalname = new string [] {"Spot","Dylan","Fido"};
      foreach(string a in animalname){
        Console.WriteLine(a);
      }
      
      
      
    }
  }
}
namespace sorting
{
  class sort
  {
    
    
    public static void linear()
    {
      int[] numbers = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100};
      Console.WriteLine("What is your number");
      int toFind = Int32.Parse(Console.ReadLine());
      int posttion = 0;
      int length = numbers.Length;
      while(posttion<length&&numbers[posttion] != toFind)
      {
        posttion++;
        
      }
      if (posttion>=length)
      {
        Console.WriteLine("Your number cant be found!");
        
      }
      else
      {
        Console.WriteLine("we have found your number at position " + posttion);
      }
      
    }
    public static void binary()
    {
      int[] numbers = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100};
      int length = numbers.length;
      Console.WriteLine("What is your number");
      int toFind = Int32.Parse(Console.ReadLine());
      int lowerbound = 0;
      int upperboud = length -1;
      bool match = false;
      while(match == false && lowerbound != upperboud)
      {
        int midpoint = ((lowerbound + upperboud)/2);
        if (numbers[midpoint] == toFind)
        {
          Console.WriteLine("We found you rnumber at " + midpoint);
          match = true;
          
        }
        else if (numers[midpoint]<toFind)
        {
          
        }
      }
    }
  }
}
