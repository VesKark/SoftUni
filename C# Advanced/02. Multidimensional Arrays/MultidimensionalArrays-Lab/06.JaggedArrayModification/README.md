# Jagged-Array Modification
  
Create a program that **reads a matrix** from the console. On the **first line**, you will get **matrix rows**.
On the **next rows lines**, you will get elements for each **column** separated with space. You will be receiving commands in the following format:
- **Add {row} {col} {value}** – **Increase** the number at the given coordinates **with the value**.
- **Subtract {row} {col} {value}** – **Decrease** the number at the given coordinates **by the value**.  

Coordinates might be invalid. In this case, you should print "**Invalid coordinates**". When you receive "**END**" you should **print the matrix** and stop the program.

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 3<br> 1 2 3<br> 4 5 6 7<br> 8 9 10<br> Add 0 0 5<br> Subtract 1 2 2<br> Subtract 1 4 7<br> END | Invalid coordinates<br> 6 2 3<br> 4 5 4 7<br> 8 9 10 |
| 4<br> 1 2 3 4<br> 5<br> 8 7 6 5<br> 4 3 2 1<br> Add 4 4 100<br> Add 3 3 100<br> Subtract -1 -1 42<br> Subtract 0 0 42<br> END | Invalid coordinates<br> Invalid coordinates<br> -41 2 3 4<br> 5<br> 8 7 6 5<br> 4 3 2 101 |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1452#5)
