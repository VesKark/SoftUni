# Match Full Name  
  
Write a C# Program to **match full names** from a list of names and **print** them on the console. 
  
## Writing the Regular Expression  

First, create a regular expression to match a valid full name, according to the conditions.  
A valid full name has the following characteristics:

 - It consists of **two words**.
 - Each word **starts** with a **capital letter**.
 - After the first letter, it **only contains lowercase letters afterward**.
 - **Each** of the **two words** should be **at least two letters long**.
 - The **two words** are separated by a **single space**.  

To help you out, we've outlined several steps:  

1. Use an online regex tester like https://regex101.com/ 
1. Check out how to use **character sets** (denoted with square brackets - "**[]**")
1. Specify that you want **two words** with a space between them (the **space character ' '**, and **not** any whitespace symbol)
1. For each word, specify that it should begin with an uppercase letter using a **character set**. The desired characters are in a range – **from 'A' to 'Z'**.
1. For each word, specify that what follows the first letter are only **lowercase letters**, one or more – use another character set and the correct **quantifier**.
1. To prevent capturing of letters across new lines, put "**\b**" at the beginning and the end of your regex. This will ensure that what precedes and what follows the match is a word boundary (like a new line).  

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| ```Bethany Taylor```, Oliver miller, sophia Johnson, SARah Wilson, ```John Smith```, Sam	        Smith | Bethany Taylor John Smith |
| ```Elvis Presley```, a a C C-```Muhammad Ali```, EE PeterpeterJR-a a xi ban D D bb b b-B B-c c EE-```Michael Jackson```, DD peter smith B B PETER BROWN IVAN DAVIES- | Elvis Presley Muhammad Ali Michael Jackson |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1667#0)  
