using System;
namespace app
{
  public class Calculator
  {
    public int add(int i, int i1)
    {
		if ((i > 0) && (i1 < 0)) { throw (new ArgumentException("i1")); }
		else if ((i < 0) && (i1 > 0)) { throw (new ArgumentException("i")); }

        return i + i1;
    }
  }
}