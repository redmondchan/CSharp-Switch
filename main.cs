using System;

class MainClass {
  public static void Main (string[] args) {

    // example with default statement
    Console.WriteLine("Pick one of the following colors: green, red, or yellow");
    var color = Console.ReadLine();

    switch(color)
    {
      case "green":
        Console.WriteLine("You picked green");
        break;
      case "yellow":
        Console.WriteLine("You picked yellow");
        break;
      case "red":
        Console.WriteLine("You picked red");
        break;
      default: 
        Console.WriteLine("You did not pick from the colors provided.");
        break;
    }

    // example without default
    // int num = 3;

    // switch (num)
    // {
    //   case 1:
    //     Console.WriteLine("Case 1");
    //     break;
    //   case 2:
    //     Console.WriteLine("Case 2");
    //     break;
    //   case 3:
    //     Console.WriteLine("Case 3");
    //     break;
    // }

    // ------------------Error examples----------------------

    // example of error for not including break
    // int num = 3;

    // switch (num)
    // {
    //   case 1:
    //     Console.WriteLine("Case 1");
    //     break;
    //   case 2:
    //     Console.WriteLine("Case 2");
    //     break;
    //   case 3:
    //     Console.WriteLine("Case 3");
    //     break;
    // }


    // example of error for different data types
    // int num = "three";

    // switch (num)
    // {
    //   case 1:
    //     Console.WriteLine("Case 1");
    //     break;
    //   case 2:
    //     Console.WriteLine("Case 2");
    //     break;
    //   case 3:
    //     Console.WriteLine("Case 3");
    //     break;
    // }
  }
}