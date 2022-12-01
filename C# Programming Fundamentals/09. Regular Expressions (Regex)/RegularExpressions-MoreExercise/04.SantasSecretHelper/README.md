# Santa's Secret Helper
  
After the successful second Christmas, Santa needs to gather information about the behavior of children to plan the presents for next Christmas.
He has a secret helper, who is sending him **encrypted information**. Your task is to **decrypt it** and create a list of the good children.  

You will receive an **integer**, which represents **a key**, and afterward some **messages**, which you **must decode by subtracting the key** from the **value of each character**.
After the decryption, to be considered a valid match, a message should:  

-	Have a name, which **starts after '@'** and contains **only letters from the Latin alphabet**.
-	Have a behavior type - "**G**"(good) or "**N**"(naughty) and must be **surrounded by "!"** (exclamation mark).

The order in the message should be the **child’s name -> child’s behavior**. They can be separated from the others by **any character except**: **'@', '-', '!', ':'** and **'>'**.  

You will be receiving messages until you are given the “**end**” command. Afterward, print the names of the children, who will receive a present, each on a new line. 
  
## Input / Constraints

-	The **first line holds n** – the number which you have to subtract from the characters – **integer in the range [1…100]**;
-	On the next lines, you will be receiving encrypted messages.
  
## Output  

Print the **names of the children**, each on a new line.

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 3<br> CNdwhamigyenumje$J$<br> CEreelh-nmguuejn$J$<br> CVwdq&gnmjkvng$Q$<br> end | Kate<br> Bobbie |
| 3<br>N}eideidmk$'(mnyenmCNlpamnin$J$<br>ddddkkkkmvkvmCFrqqru-nvevek$J$nmgievnge<br>ppqmkkkmnolmnnCEhq/vkievk$Q$<br>yyegiivoguCYdohqwlqh/kguimhk$J$<br>end | Kim<br> Connor<br> Valentine |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1754#3)
