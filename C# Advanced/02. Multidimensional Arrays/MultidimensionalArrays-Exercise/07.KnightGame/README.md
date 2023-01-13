# Knight Game

Chess is the oldest game, but it is still popular these days. For this task we will use only one chess piece – the **Knight**.

The **knight moves to the nearest square**, but not on the same row, column or diagonal. (This can be thought of as moving two squares horizontally,
then one square vertically, or moving one square horizontally, then two squares vertically— i.e. in an **"L" pattern**.) 

The knight game is played on a **board** with dimensions **N x N** and a lot of chess **knights 0 <= K <= N2**. 

You will receive a board with **'K'** for **knights** and **'0'** for **empty cells**.  
Your task is to **remove a minimum of the knights**, so there will be no knights left that can attack another knight. 


## Input

-	On the **first line**, you will receive the **N side of the board**.
-	On the **next N lines**, you will receive strings with **Ks** and **0s**.

## Output

-	Print a single integer with the **minimum number of knights** that needs **to be removed**.

## Constraints

-	Size of the board will be 0 < N < 30
-	Time limit: 0.3 sec. Memory limit: 16 MB.

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 5<br> 0K0K0<br> K000K<br> 00K00<br> K000K<br> 0K0K0 | 1 |
| 2<br> KK<br> KK | 0 |
| 8<br> 0K0KKK00<br> 0K00KKKK<br> 00K0000K<br> KKKKKK0K<br> K0K0000K<br> KK00000K<br> 00K0K000<br> 000K00KK | 12 |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Compete/Index/1455#6)
