# Treasure Finder
  
Write a program that **decrypts a message** by a given **key** and gathers information about hidden **treasure type** and its **coordinates**.
On the **first line** you will receive a **key** (sequence of numbers). On the **next few lines** until you receive "**find**" you will get lines of **strings**.  

You have to **loop** through every string and **decrease the ascii code of each character** with a corresponding **number of the key sequence**.
The way you choose a key number from the sequence is just looping through it.  
If the **length of the key** sequence is **less than the string** sequence, you start **looping from the beginning** of the key.  

**After decrypting** the message you will get a **type of treasure** and its **coordinates**.
The **type** will be **between** the symbol '**&**' and the **coordinates** will be **between** the symbols '**<**' and '**>**'.  

For each line print the type and the coordinates in format "**Found {type} at {coordinates}**".

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 1 2 1 3<br> ikegfp'jpne)bv=41P83X@<br> ujfufKt)Tkmyft'duEprsfjqbvfv=53V55XA<br> find | Found gold at 10N70W<br> Found Silver at 32S43W |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1338#2) 
