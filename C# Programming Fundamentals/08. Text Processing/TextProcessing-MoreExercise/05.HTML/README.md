# HTML
  
You will receive **3 lines of input**. On the **first line** you will receive a **title of an article**. On the **next line** you will receive the **content of that article**.
On the **next n lines** until you receive "**end of comments**" you will get the **comments about the article**.  

**Print** the whole information in **HTML format**.  

The **title** should be in <ins>h1-tag</ins> (**\<h1>\</h1>**); the **content** in <ins>article-tag</ins> (**\<article>\</article>**); each **comment** should be in <ins>div-tag</ins> (**\<div>\</div>**).

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| SoftUni Article<br> Some content of the SoftUni article<br> some comment<br> more comment<br> last comment<br> end of comments | \<h1><br>&emsp;     SoftUni Article<br> \</h1><br> \<article><br>&emsp;     Some content of the SoftUni article<br> \</article><br> \<div><br>&emsp;     some comment<br> \</div><br> \<div><br>&emsp;      more comment<br> \</div><br> \<div><br>&emsp;     last comment<br> \</div> |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1338#4) 
