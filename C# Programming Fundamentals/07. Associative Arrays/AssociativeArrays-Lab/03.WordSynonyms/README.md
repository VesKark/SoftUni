# Word Synonyms
  
Write a program, which keeps a dictionary with synonyms. The **key** of the dictionary will be the **word**.
The **value** will be a **list of all the synonyms** of that word. You will be given a number **n** – the **count of the words**.
After each word, you will be given a synonym, so the count of lines you have to read from the console is **2 * n**.
You will be receiving a **word and a synonym** each on a separate line like this:

- **{word}**
- **{synonym}**

If you get the same word twice, just add the new synonym to the list. Print the words in the following format:  

**{word} - {synonym1, synonym2… synonymN}**

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 3<br> cute<br> adorable<br> cute<br> charming<br> smart<br> clever | cute - adorable, charming<br> smart - clever |
| 2<br> task<br> problem<br> task<br> assignment | task - problem, assignment |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/1212#2) 
