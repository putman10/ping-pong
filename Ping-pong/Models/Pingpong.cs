
using System;
using System.Collections;
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
  }
}
