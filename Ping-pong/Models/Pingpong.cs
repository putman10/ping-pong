
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PingPong
{
  public class Pingpong
  {
    public int[] PingPongGenerator(int n)
    {
      int[] numbers = Enumerable.Range(0,n).ToArray();
      return numbers;
    }

    public string[] ReplaceLoop(int[] array)
    {
      string[] finalString = new string[4];
      for (int i = 0; i < array.Length; i++){
        if (DivisibleByBoth(i))
        {
          finalString[i] = "pingpong";
        }
        else if (DivisibleByThree(i))
        {
          finalString[i] = "pong";
        }
        else if (DivisibleByFive(i))
        {
          finalString[i] = "ping";
        }
        else
        {
          finalString[i] = "test";
        }
        Console.WriteLine(finalString[i]);
      }
      return finalString;
    }

    public bool DivisibleByThree(int n)
    {
      if (n % 3 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
      }

    public bool DivisibleByFive(int n)
    {
      if (n % 5 == 0)
      {
      return true;
      }
      else
      {
        return false;
      }
    }

    public bool DivisibleByBoth(int n)
    {
      if (n % 5 == 0 && n % 3 == 0)
      {
      return true;
      }
      else
      {
      return false;
      }
    }

  }
}
