# Maximum and Minimum Element

You have an empty sequence and you will be given **N queries**. Each query is one of these three types:  
- 1 – **Push** the element x into the stack.  
- 2 – **Delete** the element present at the top of the stack.  
- 3 – **Print the maximum** element in the stack.  
- 4 – **Print the minimum** element in the stack.  

After you go through all of the queries, print the stack in the following format: "**{n}, {n1}, {n2} …, {nn}**".

## Input

- The **first line** of input contains an integer – **N**.
- The **next N lines** each contain an above-mentioned **query**. (It is guaranteed that each query is valid.)

## Output

- For each type 3 or 4 queries, print the **maximum/minium element** in the stack on a new line.

## Constraints

- 1 ≤ N ≤ 105
- 1 ≤ x ≤ 109
- 1 ≤ type ≤ 4
- If there are **no elements** in the stack, **don't print anything** on commands 3 and 4

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 9<br> 1 97<br> 2<br> 1 20<br> 2<br> 1 26<br> 1 20<br> 3<br> 1 91<br> 4 | 26<br> 20<br> 91, 20, 26 |
| 10<br> 2<br> 1 47<br> 1 66<br> 1 32<br> 4<br> 3<br> 1 25<br> 1 16<br> 1 8<br> 4 | 32<br> 66<br> 8<br> 8, 16, 25, 32, 66, 47 |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1447#2) 
