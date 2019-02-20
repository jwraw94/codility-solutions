using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int input = A.Length, i = 0, z = 0, j = 0;
        
        while (j < input ) {
            z += A[j];
            j++;
            i += j;
        }
        
        return i + j + 1 - z ;
    }
}
