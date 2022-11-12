# SoftUni Karaoke  

SoftUni cultivates talent whether it's coding talent or something else and in this case, something else is singing.
Since you love music you want to take part in the event but as a programmer you simply lack the "something else" so your job is to make the software to track participants' awards.  

**On the first line**, you will receive a **list with all participants that applied for performance**.  
**On the second line**, you will receive **the list with all available songs**.  
**On the next lines**, until the "**dawn**" **command**, you will get the **names of people, the song that they are performing** on stage and **the award they get** from the audience.  

However, not every time the plan goes according to schedule.
In other words, **everyone** (listed or not) **can go on stage and perform a song that is not even available** and **he still gets awards from the audience**.
However, you should **record only the awards for listed participants** that **perform songs available in the list**.
In case someone is **not listed** or sings a **song that is not available** you should **not record neither the participant, nor his award**.  

When the "dawn" comes, you need to **print all participants**, the **count of the unique awards they received** and all unique awards.
Participants should be **sorted by number of awards** in **descending order** and **then by participant name alphabetically**.
Awards should be **sorted in alphabetical order**.
  
## Input  

- On the first line, you will receive list with all participants that applied for performance in the format: "**{participant}, {participant} … {participant}**"
- On the second line, you will get all available songs in the in the format: "**{song}, {song} … {song}**"
- On the next lines, until the "**dawn**" command you will receive every stage performance in the format: "**{participant}, {song}, {award}**" 
- Performances and songs will be **separated by a comma and a single or multiple white spaces**
  
## Output  

- Print all participants along with the number of unique awards they won in the format: 
  - "**{participant}: {award count} awards**"
  - "**--{award}**"
- Print participants **sorted by unique awards count in descending order**. If two participants have the same unique award count, **sort them alphabetically by name**
- Print unique **awards** for every participant **sorted alphabetically**
- If there are no **awards**, print "**No awards**"
  
## Constraints  

- The number of total participants will be in range [1 … 100]
- The number of total songs will be in range [1 … 100]
- The input will always end with the "dawn" command

## Sample Input and Output  
    
| **Input** | **Output** |  
| :--- | :--- | 
| Trifon, Vankata, Gesha
Dragana - Kukavice, Bon Jovi - It's my life, Lorde - Royals<br> Gesha, Bon Jovi - It's my life, Best Rock<br> Vankata, Dragana - Kukavice, Best Srabsko<br> Vankata, Dragana - Kukavice, Best Srabsko<br> Vankata, Dragana - Kukavice, Stiga Tolko Srabsko<br> Vankata, PHP Web, Educational 101<br> dawn | Vankata: 2 awards<br> --Best Srabsko<br> --Stiga Tolko Srabsko<br> Gesha: 1 awards<br> --Best Rock |
| Gesha<br> Bon Jovi - It's my life<br> Gesha, Bon Jovi - It's my life, Best Rock<br> Vankata, Dragana - Kukavice, Best Srabsko<br> Vankata, Dragana - Kukavice, Stiga Tolko Srabsko<br> Vankata, PHP Web, Educational 101<br> dawn | Gesha: 1 awards<br> --Best Rock |
| Sino<br> Vasko Naidenov - Nova Godina<br> dawn | No awards |

## Testing in the Judge System  
    
Test your solution here: [Judge System Link](https://judge.softuni.org/Contests/Practice/Index/376#1)
