# The Pianist 

*You are a pianist, and you like to keep a list of your favorite piano pieces. Create a program to help you organize it and add, change, remove pieces from it!*  

On the first line of the standard input, you will receive an integer **n** – the **number of pieces** you will initially have.
On the next **n** lines, the **pieces themselves** will follow with their **composer** and **key**, separated by "**|**" in the following format: "**{piece}|{composer}|{key}**".  

Then, you will be receiving different **commands**, each on a new line, separated by "**|**", until the "**Stop**" command is given:

- "**Add|{piece}|{composer}|{key}**":
  - You need to ***add the given piece*** with the information about it to the other pieces and print:  
  "**{piece} by {composer} in {key} added to the collection!**"
  - If the piece ***is already in the collection***, print:  
  "**{piece} is already in the collection!**"
- "**Remove|{piece}**":
  - If the piece is in the collection, ***remove it*** and print:  
  "**Successfully removed {piece}!**"
  - Otherwise, print:  
  "**Invalid operation! {piece} does not exist in the collection.**"
- "**ChangeKey|{piece}|{new key}**":
  - If the piece is in the collection, ***change its key with the given one*** and print:  
  "**Changed the key of {piece} to {new key}!**"
  - Otherwise, print:  
  "**Invalid operation! {piece} does not exist in the collection.**"  

Upon receiving the "**Stop**" command, you need to print all pieces in your collection in the following format:  
"**{Piece} -> Composer: {composer}, Key: {key}**"
  
## Input / Constraints  

- You will receive **a single integer** at first – **the initial number of pieces in the collection**
- For each piece, you will receive a single line of text with information about it.
- Then you will receive multiple commands in the way described above until the command "**Stop**".
  
## Output  

- All the output messages with the appropriate formats are described in the problem description.

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| 3<br> Fur Elise\|Beethoven\|A Minor<br> Moonlight Sonata\|Beethoven\|C# Minor<br> Clair de Lune\|Debussy\|C# Minor<br> Add\|Sonata No.2\|Chopin\|B Minor<br> Add\|Hungarian Rhapsody No.2\|Liszt\|C# Minor<br> Add\|Fur Elise\|Beethoven\|C# Minor<br> Remove\|Clair de Lune<br> ChangeKey\|Moonlight Sonata\|C# Major<br> Stop | Sonata No.2 by Chopin in B Minor added to the collection!<br> Hungarian Rhapsody No.2 by Liszt in C# Minor added to the collection!<br> Fur Elise is already in the collection!<br> Successfully removed Clair de Lune!<br> Changed the key of Moonlight Sonata to C# Major!<br> Fur Elise -> Composer: Beethoven, Key: A Minor<br> Moonlight Sonata -> Composer: Beethoven, Key: C# Major<br> Sonata No.2 -> Composer: Chopin, Key: B Minor<br> Hungarian Rhapsody No.2 -> Composer: Liszt, Key: C# Minor |
| 4<br> Eine kleine Nachtmusik\|Mozart\|G Major<br> La Campanella\|Liszt\|G# Minor<br> The Marriage of Figaro\|Mozart\|G Major<br> Hungarian Dance No.5\|Brahms\|G Minor<br> Add\|Spring\|Vivaldi\|E Major<br> Remove\|The Marriage of Figaro<br> Remove\|Turkish March<br> ChangeKey\|Spring\|C Major<br> Add\|Nocturne\|Chopin\|C# Minor<br> Stop | Spring by Vivaldi in E Major added to the collection!<br> Successfully removed The Marriage of Figaro!<br> Invalid operation! Turkish March does not exist in the collection.<br> Changed the key of Spring to C Major!<br> Nocturne by Chopin in C# Minor added to the collection!<br> Eine kleine Nachtmusik -> Composer: Mozart, Key: G Major<br> La Campanella -> Composer: Liszt, Key: G# Minor<br> Hungarian Dance No.5 -> Composer: Brahms, Key: G Minor<br> Spring -> Composer: Vivaldi, Key: C Major<br> Nocturne -> Composer: Chopin, Key: C# Minor |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/2525#2)
