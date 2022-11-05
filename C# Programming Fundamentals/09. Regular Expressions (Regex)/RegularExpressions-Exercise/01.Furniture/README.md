# Furniture  
  
Create a program to calculate the total cost of different types of furniture. You will be given some lines of input until you receive the line "**Purchase**". For the line to be valid it should be in the following format:  

"**>>{furniture name}<<{price}!{quantity}**"  

The price can be a floating-point number or a whole number. Store the names of the furniture and the total price. At the end print each bought furniture on a separate line in the format:  

"**Bought furniture:  
{1st name}  
{2nd name}  
…**"  

And on the last line print, the following: "**Total money spend: {spend money}**" formatted to the second decimal point. 

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| >>Sofa<<312.23!3<br> >>TV<<300!5<br> >Invalid<<!5<br> Purchase | Bought furniture:<br> Sofa<br> TV<br> Total money spend: 2436.69 |
| >>Chair<<412.23!3<br> >>Sofa<<500!5<br> >>Recliner<<<<!5<br> >>Bench<<230!10<br> >>>>>>Rocking chair<<!5<br> >>Bed<<700!5<br> Purchase | Bought furniture:<br> Chair<br> Sofa<br> Bench<br> Bed<br> Total money spend: 9536.69 |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Compete/Index/1668#0)  
