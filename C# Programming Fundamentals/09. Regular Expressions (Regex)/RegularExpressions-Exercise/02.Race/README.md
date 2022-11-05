# Race  
  
Write a program that processes information about a race.
On the **first line**, you will be given a **list of participants separated by** "**,** ".
On the next few lines until you receive a line "**end of the race**" you will be given some info which will be some **alphanumeric characters**.
In between them, you could have some **extra characters which you should ignore**. For example: "**G!32e%o7r#32g$235@!2e**".
The **letters are the name** of the person and the **sum of the digits is the distance** he ran. So here we have **George** who ran **29 km**.
Store the information about the person only **if the list of racers contains the name of the person**.
If you receive the **same person more than once just add the distance to his old distance**. At the end **print the top 3 racers** in the format:  

"**1st place: {first racer}  
2nd place: {second racer}  
3rd place: {third racer}**"  

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| George, Peter, Bill, Tom<br> G4e@55or%6g6!68e!!@<br> R1@!3a$y4456@<br> B5@i@#123ll<br> G@e54o$r6ge#<br> 7P%et^#e5346r<br> T$o553m&6<br> end of the race | 1st place: George<br> 2nd place: Peter<br> 3rd place: Tom  |
| Ivan, Peter, James, Kyle<br> I4v@43an%66?77!!@<br> G1@!3u$s445s6@<br> B3@i@#245ll<br> I&v54a%66n@<br> 7P%et^#e5346r<br> J$a553m&e6s<br> K2y3=l/^e23<br> end of the race | 1st place: Ivan<br> 2nd place: Peter<br> 3rd place: James |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Compete/Index/1668#1)  
