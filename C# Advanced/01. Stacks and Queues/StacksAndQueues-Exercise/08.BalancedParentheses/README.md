# Balanced Parenthesis

Given a sequence consisting of parentheses, determine whether the **expression is balanced**.
A sequence of parentheses is balanced, if every **open parenthesis** can be **paired** equally with a **closing parenthesis** that occurs after the former.
Also, the **interval between them must be balanced**.  
You will be given **three types of parentheses**: **(**, **{**, and **[**.

## Input

- Each input consists of a single line, the **sequence of parentheses**.

## Output

- For each test case, print on a new line "**YES**", if the parentheses are balanced. 
- Otherwise, print "**NO**". Do not print the quotes.

## Constraints

- 1 ≤ lens ≤ 1000, where the lens is the length of the sequence.
- **Each character** of the sequence **will be one of** {, }, (, ), [, ].

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| {[()]} | YES |
| {[(])} | NO |
| {{[[(())]]}} | YES |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1447#7) 
