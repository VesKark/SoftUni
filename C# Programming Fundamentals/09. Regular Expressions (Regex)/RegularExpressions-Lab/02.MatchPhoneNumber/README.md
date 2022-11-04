# Match Phone Number  
  
Create a regular expression to match a **valid phone number** from **Sofia**.  
After you find all **valid phones**, **print** them on the console, separated by a **comma and a space** "**,** ". 
  
## Writing the Regular Expression  

First, create a regular expression to match a valid phone number, according to the conditions.  
A valid phone number has the following characteristics:

 - It starts with "**+359**".
 - Then, it is followed by the area code (always **2**).
 - After that, it’s followed by the **number** itself:
   - The number consists of **7 digits** (separated into **two groups** of **3** and **4 digits** respectively). 
 - The different **parts** are **separated** by **either a space (' ') or a hyphen** ('**-**'). 

You can use the following RegEx properties to **help** with the matching:  

1. Use **quantifiers** to match a **specific number** of **digits**.
1. Use a **capturing group** to make sure the delimiter is **only one of the allowed characters (space or hyphen)** and **not** a **combination** of both (e.g. +359 2-111 111 has **mixed delimiters**, it is **invalid**). Use a **group backreference** to achieve this.
1. Add a **word boundary** at the **end** of the match to avoid **partial matches** (the last example on the right-hand side).
1. Ensure that before the '**+**' sign there is either a **space** or the **beginning of the string**.

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| ```+359 2 222 2222```, 359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 ```+359-2-222-2222``` | +359 2 222 2222, +359-2-222-2222 |
| ```+359 2 234 2324```, 359-2-111-9876, +359/8/655/5432, +359-2 222 2222, +359 2-222-2222, +359-2-234-345, +359-2-123-45678, ```+359-2-222-2222```, ```+359 2 654 1234``` | +359 2 234 2324, +359-2-222-2222, +359 2 654 1234 |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](hthttps://judge.softuni.org/Contests/Practice/Index/1667#1)
