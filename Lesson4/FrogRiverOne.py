# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")

def solution(X, A):
    # write your code in Python 3.6
    
    position = 0
    # Create a list of X elements, set to false.
    leaves = [False] * X
    
    # Loop over list, with a counter called minute. If the leaf in the list is less than X, set that leaf to true. 
    for minute, leaf in enumerate(A):
        if leaf <= X:
            leaves[leaf - 1] = True
        
        # Check for the position if the leaf has landed for the current minute, if it has, check for the next positions to see fi they have.
        while leaves[position] == True:
            position += 1
            
            # If all the leaves needed have landed, then the current minute is the time taken.
            if position == X:
                return minute
    
    return -1
