using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int left = 0;
        int total = A.Sum();
        
        int min = 100000;
        
        for ( int j = 0; j < A.Length - 1; j++ ) {
            left = left + A[j];
            
            if (Math.Abs(total - (2 * left)) < min) {
                min = Math.Abs(total - (2 * left));
            }
        }
        return min;
    }
}
