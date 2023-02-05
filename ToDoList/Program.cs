using System;
using System.Collections.Generic;

 using ToDoList.Models;

 namespace ToDoList
 {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Would you like to add an item to your list or view you total list? Type 'add' or 'view'.");
      string description = Console.ReadLine();
      Item newItem = new Item(description);
      Console.WriteLine("you have added " + newItem.Description + " to your list.");
      string input = Console.ReadLine();
      string lcInput = input.ToLower();
      
    
      if (lcInput == "add")
      {
        Main();
      }else if (lcInput == "view")
      {
        List<Item> result = Item.GetAll();
        int listNumber = 1;
        foreach(Item itemElement in result)
        {
          Console.WriteLine(listNumber + ". " + itemElement.Description);
          listNumber++;
        }
      } else {
        Console.WriteLine("We did not understand your input. Please try again.");
        Main();
      }
    }
  }
 }