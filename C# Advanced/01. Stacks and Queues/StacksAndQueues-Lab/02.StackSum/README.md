# Stack Sum

Create a program that:
- **Reads** an input of **integer numbers** and **adds** them to a **stack**.
- **Reads** and executes **commands** until "**end**" is received.
- **Process** the following **commands**:
  - **Add \<n1> \<n2>**: pushes two numbers into the stack
  - **Remove \<n>**: removes the n elements from the stack or does nothing if the stack holds less than n elements.
- **Prints the sum** of the remaining elements of the **stack**.
 
## Input

- On the **first line**, you will receive an **array of integers** (space-separated).
- On the **next lines**, until the "**end**" command is given, you will **receive commands** – a single command and one or two numbers after the command, depending on what command you are given.
  - If the **command** is "**add**", you will **always** be given exactly **two numbers after the command**, which you need to **add to the stack**.
  - If the **command** is "**remove**", you will **always** be given exactly **one number after the command**, which represents the count of the numbers you need to **remove from the stack**. If there are **not enough elements**, **skip** the command.
- Commands are **case-insensitive**, which means that "**Add**", "**add**" and "**aDD**" are the same command.
- A **single space** is used **as a separator** between commands and numbers.

## Output

When the command "**end**" is received, you need to **print the sum** of the remaining elements in the stack.

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 1 2 3 4<br> adD 5 6<br> REmove 3<br> eNd | Sum: 6 |
| 3 5 8 4 1 9<br> add 19 32<br> remove 10<br> add 89 22<br> remove 4<br> remove 3<br> end | Sum: 16 |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1445#1) 
