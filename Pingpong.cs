using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter a number");
    string stringNumber = Console.ReadLine();
    int numberRange = -1;
    bool repeat = true;
    while(repeat){
      try {
        numberRange = int.Parse(stringNumber);
        repeat=false;
      }
      catch(FormatException){
        Console.WriteLine("Please enter a number.");
        stringNumber = Console.ReadLine();
      }
    }
    for(int num = numberRange; num >= 1; num--){
      if(num % 3 == 0 && num % 5 == 0){
        Console.WriteLine("ping-pong");
      } else if (num % 5 == 0){
        Console.WriteLine("pong");
      } else if ( num % 3 == 0){
        Console.WriteLine("ping");
      } else {
        Console.WriteLine(num.ToString());
      }
    }
  }
}
