# Simple Text Editor

You are given an empty text. Your task is to implement 4 commands related to manipulating the text.
- **1 string** -> **appends** the string to the end of the text.
- **2 count** -> **erases** the last count elements from the text.
- **3 index** -> **returns** the element at position **index** from the text.
- **4** -> **undoes** the last not undone command of type 1 or 2 and returns the text to the state before that operation.

## Input

- The **first line** contains **n** – the **number of operations**.
- Each of the **following n lines** contains the name of the **operation, followed by the command argument** (if any), separated by space in the following format "**CommandName Argument**".

## Output

- For each **operation of type 3** print a single line with the returned **character of that operation**.

## Constraints

- 1 ≤ N ≤ 105.
- The length of the text will not exceed 1000000.
- All input characters are English letters.
- It is guaranteed that the sequence of input operations is possible to perform.

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 8<br> 1 abc<br> 3 3<br> 2 3<br> 1 xy<br> 3 2<br> 4<br> 4 <br> 3 1 | c<br> y<br> a |
| 9<br> 1 HelloThere<br> 3 7<br> 2 2<br> 3 5<br> 4<br> 3 7<br> 4<br> 1 TestPassed<br> 3 5 | h<br> o<br> h<br> P |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1447#8) 
