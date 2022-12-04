# Text Filter
  
Write a program that takes a **text** and a **string of banned words**. All words included in the ban list should be replaced with **asterisks "\*"**, equal to the word's length.
The entries in the ban list will be separated by a **comma and space ", "**.  

The ban list should be entered on the first input line and the text on the second input line. 


## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| Linux, Windows<br> It is not **Linux**, it is GNU/**Linux**. **Linux** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/**Linux**! Sincerely, a **Windows** client | It is not ``*****``, it is GNU/``*****``. ``*****`` is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/``*****``! Sincerely, a ``*******`` client |
|  |  |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1216#3) 
