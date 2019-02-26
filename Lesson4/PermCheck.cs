using System;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int i = 1;
        Array.Sort(A);
        
        if ( A.Length == 1) {
            if (A[0] == 1 ) {
                return 1;
            } else {
                return 0;
            }
        }
        
        while (i < A.Length ) {
            if ( A[i] != i + 1 ) {
                return 0;
            } else {
                i++;
            }
        }
        return 1;
    }
}
