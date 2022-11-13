# The Imitation Game 

*During World War 2, you are a mathematician who has joined the cryptography team to decipher the enemy's enigma code. Your job is to create a program to crack the codes.*  

On the first line of the input, you will receive the **encrypted message**.
After that, until the "**Decode**" command is given, **you will be receiving strings** with **instructions** for different **operations**
that need to be performed upon the **concealed message** to **interpret it** and reveal its true content.
There are several types of instructions, split by '**|**'.  

- "**Move {number of letters}**":
  - **Moves** the **first n letters** to the **back** of the string
- "**Insert {index} {value}**":
   - **Inserts** the given value **before the given index** in the string
- "**ChangeAll {substring} {replacement}**":  
   - **Changes all occurrences** of the given substring with the replacement text
  
## Input / Constraints  

- On the first line, you will receive a string with a message.
- On the following lines, you will be receiving commands, split by '**|**' .
  
## Output  

- After the "Decode" command is received, print this message:  
- "**The decrypted message is: {message}**"

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| zzHe<br> ChangeAll\|z\|l<br> Insert\|2\|o<br> Move\|3<br> Decode | The decrypted message is: Hello |
| owyouh<br> Move\|2<br> Move\|3<br> Insert\|3\|are<br> Insert\|9\|?<br> Decode | The decrypted message is: howareyou? |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/2525#0)
