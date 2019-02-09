using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        /* Iterate through a supplied array, creating a new array shifted by K places.
           Set n to the current position, plus whatever it's meant to be shifted by.
           If this new position exceeds the bounds of the array, it should loop back to the start, using the modulo operator. */
        
        int length = A.Length;
        int[] B = new int[length];
        
        for( int i = 0; i < length; i++){
            int n = (K + i)%length;
            B[n] = A[i];
        }
        return B;
    }
}
