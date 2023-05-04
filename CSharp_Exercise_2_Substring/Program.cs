using System;
public class CSharp_Exercise_2_Substring
{
  public static void Main()
  {
    string inputStr;
    string searchStr;

    bool strExist; // Boolean value

      Console.WriteLine("Check whether a given substring is present in the given string:");
      Console.WriteLine("---------------------------------------------------------------");
      Console.Write("Input the string: ");
      inputStr = Console.ReadLine();

      Console.Write("Input the substring to search: ");
      searchStr = Console.ReadLine();
      strExist = inputStr.Contains(searchStr); // If the search string exist in the input string  
      if (strExist)                            // then the string is true
        Console.WriteLine("The substring exists in the string"); // If it exist (true) this answer will show up
      else
        Console.WriteLine("The substring does not exists in the string"); // If it does not exist (!true) this answer will show up
  }
}
