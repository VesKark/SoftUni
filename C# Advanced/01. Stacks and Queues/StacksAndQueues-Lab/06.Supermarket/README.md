# Supermarket
  
You are given a **sequence of input strings**, each staying on a separate line.
Each input string holds either a **customer name**, or the **command** "**Paid**" or the command "**End**". Your task is to read and process the input:
- When you receive a **customer name**, **add** it to the **queue**.
- When you receive the "**Paid**" command, **print** the customer **names from the queue** (each at separate line), then empty the queue.
- When you receive the "**End**" command, **print** the **count of the remaining customers** from the queue in the format: "**{count} people remaining.**" and stop processing the commands (see the examples below).

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| Liam<br> Noah<br> James<br> **Paid**<br> Oliver<br> Lucas<br> Logan<br> Tiana<br> **End** | Liam<br> Noah<br> James<br> 4 people remaining. |
| Amelia<br> Thomas<br> Elias<br> **End** | 3 people remaining. |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1445#5) 
