# Traffic Jam

Create a program that simulates the **queue** that forms during a **traffic jam**. During a traffic jam, only **N cars can pass** the crossroads when the light goes **green**.
Then the program reads the **vehicles that arrive** one by one and adds them **to the queue**.  

When the **light goes green**, N number of cars pass the crossroads and **for each**, a message "**{car} passed!**" is displayed.  
When the "**end**" command is given, terminate the program and display a message with the **total number of cars that passed** the crossroads.

## Input

- On the **first line**, you will receive **N** – the **number of cars** that can pass during a green light.
- On the **next lines**, until the "**end**" command is given, you will receive **commands** – a single string, either a **car or** "**green**".

## Output

- Every time the "**green**" command is given, **print** out a message for every car that passes the crossroads in the format "**{car} passed!**".
- When the "**end**" command is given, **print** out a message in the format "**{number of cars} cars passed the crossroads.**".

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 4<br> Hummer H2<br> Audi<br> Lada<br> Tesla<br> Renault<br> Trabant<br> Mercedes<br> MAN Truck<br> **green**<br> **green**<br> Tesla<br> RenaultTrabant<br> **end** | Hummer H2 passed!<br> Audi passed!<br> Lada passed!<br> Tesla passed!<br> Renault passed!<br> Trabant passed!<br> Mercedes passed!<br> MAN Truck passed!<br> 8 cars passed the crossroads. |
| 3<br> Enzo's car<br> Jade's car<br> Mercedes CLS<br> Audi<br> **green**<br> BMW X5<br> green<br> **end** | Enzo's car passed!<br> Jade's car passed!<br> Mercedes CLS passed!<br> Audi passed!<br> BMW X5 passed!<br> 5 cars passed the crossroads. |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1445#7) 
