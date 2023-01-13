# Matrix Shuffling

Write a program that reads a string matrix from the console and performs certain operations with its elements.
User input is provided in a similar way as in the problems above – first, you **read the dimensions** and then **the data**. 

Your program should then receive commands in the format: "**swap row1 col1 row2 col2**", where row1, col1, row2, col2 are **coordinates** in the matrix.
For a command to be valid, it should start with the "**swap**" keyword along with **four valid coordinates** (no more, no less).  
You should **swap the values at the given coordinates** (*cell [row1, col1]* with *cell [row2, col2]*) and **print the matrix at each step** (thus you'll be able to check if the operation was performed correctly). 

If the **command is not valid** (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist),
print "**Invalid input!**" and move on to the next command. Your program should finish when the string "**END**" is entered.


## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 2 3<br> 1 2 3<br> 4 5 6<br> swap 0 0 1 1<br> swap 10 9 8 7<br> swap 0 1 1 0<br> END | 5 2 3<br> 4 1 6<br> Invalid input!<br> 5 4 3<br> 2 1 6 |
| 1 2<br> Hello World<br> 0 0 0 1<br> swap 0 0 0 1<br> swap 0 1 0 0<br> END | Invalid input!<br> World Hello<br> Hello World |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Compete/Index/1455#3)
