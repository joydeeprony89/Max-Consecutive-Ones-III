using System;

namespace Max_Consecutive_Ones_III
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] A = new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
      int k = 3;
      Program p = new Program();
      var answer = p.longestOnes(A, k);
      Console.WriteLine(answer);
    }

    public int longestOnes(int[] A, int K)
    {
      int zeroCount = 0, start = 0, res = 0;
      for (int end = 0; end < A.Length; end++)
      {
        if (A[end] == 0) zeroCount++;
        while (zeroCount > K)
        {
          if (A[start] == 0) zeroCount--;
          start++;
        }
        res = Math.Max(res, end - start + 1);
      }
      return res;
    }
  }
}
