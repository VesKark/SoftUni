# SoftUni Bar Income  
  
Let's take a break and visit the game bar at SoftUni. It is about time for the people behind the bar to go home and you are the person who has to draw the line and calculate the money from the products that were sold throughout the day. Until you receive a line with the text "**end of shift**" you will be given lines of input. But before processing that line you have to do some validations first.  

**Each valid order** should have a **customer, product, count, and a price**:  

- A valid customer's name should be **surrounded by '%'** and must **start with a capital letter**, followed by **lower-case letters**
- A valid product **contains any word character** and must be **surrounded by '<' and '>'** 
- A valid count is an **integer, surrounded by '|'**
- A valid price is any **real number followed by '$'**  

The parts of a valid order should appear in the order given: **customer, product, count, and price**.  
Between each part there can be other symbols, except (**'|', '$', '%' and '.'**)  
For each valid line print on the console: "**{customerName}: {product} - {totalPrice}**"  
When you receive "**end of shift**" print the total amount of money for the day **rounded to 2 decimal places** in the following format: "**Total income: {income}**". 
  
## Input / Constraints  

 - Strings that you have to process until you receive text "**end of shift**".
  
## Output  

- Print all of the valid lines in the format "**{customerName}: {product} - {totalPrice}**"
- After receiving "**end of shift**" print the total amount of money for the day **rounded to 2 decimal places** in the following format: "**Total income: {income}**"
- Allowed working **time / memory: 100ms / 16MB**.

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| %George%\<Croissant\>\|2\|10.3$<br> %Peter%\<Gum\>\|1\|1.3$<br> %Maria%\<Cola\>\|1\|2.4$<br> end of shift | George: Croissant - 20.60<br> Peter: Gum - 1.30<br> Maria: Cola - 2.40<br> Total income: 24.30 |
| %InvalidName%\<Croissant\>\|2\|10.3$<br> %Peter%\<Gum\>1.3$<br> %Maria%\<Cola\>\|1\|2.4<br> %Valid%\<Valid\>valid\|10\|valid20$<br> end of shift | Valid: Valid - 200.00<br> Total income: 200.00 |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Compete/Index/1668#2)
