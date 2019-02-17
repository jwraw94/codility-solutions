using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
// Count the minimal number of jumps that the small frog must perform to reach its target.

class Solution {
    public int solution(int X, int Y, int D) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int count;
        
        count = (Y - X)/D;
        
        // Count won't include the last jump needed, if it's a partial jump. If there's an extra bit to jump, add 1.
        if ((Y - X)%D > 0) {
            count = count + 1;
        }
        
        return count;
    }
}
