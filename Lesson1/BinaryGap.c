int solution(int N) {
    // write your code in C99 (gcc 6.2.0)
    /* currentGap stores the number of 0's current encountered after a 1.
       maxGap stores the max number of 0's enclosed by 1's encountered so far.
       prevGap is used to identify if a sequence of 0's started with a 1 or not.
       The bitwise operator '&' is used to test if the current bit of the input number is a 1, if it is, set prevGap to > 0.
       If not, it's a 0, and if prevGap is > 0, currentGap is incremented. The process then moves on to the next bit. */
       
    
    int currentGap = 0;
    int maxGap = 0;
    int prevGap = 0;
    
    while(N) {
        if (N & 1){
            prevGap++;
            if (currentGap > maxGap) {
                maxGap = currentGap;
            }
            currentGap = 0;
        }
        else
        {
            if (prevGap > 0) {
                currentGap++;
            }
        }
        N >>= 1;
    }
    return maxGap;
}
