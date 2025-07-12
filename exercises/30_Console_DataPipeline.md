# 20 Console: Data Pipeline


give em one denormalized csv file (read file), and have them split it into 3 normalized csv files (write files)
- with expected data ranges for each column

handle more small files to same way, but these contain various bad data
- columns out of order
- missing columns
- extra columns
- null in non nullable field sometimes
- wrong data type in field sometimes
don't process the bad rows, just don't let them kill your program

possibly go from multiple files to one denormalized one, as well








**Purpose**: This exercise will show that you can operate on files: create, write, append, read, close.

(I couldn't find a standard game that would work through these operations, so this exercise is quite contrived.)

**Requirements**:  
- Prompt the user to give you a block of text.
- Split the text block into words (split on whitespace).
- Based on the first letter of each word, store the words to a text file named "{first-letter}.txt".
  - Use a case-insensitive match.
  - Ignore anything that does not start with an alphabet character.
  - Check if the file needs to be created or not.
  - Append to the file if it already exists.
  - Store each word on a new line.
- Loop on adding blocks of text until the user enters "STOP".
- The last step is to output all the words you've stored, starting with "a"s and ending with "z"s.
  - Do a fresh read from the files, rather than keeping this all in memory.
  - For each file, output all the words separated by spaces onto one line.
- Write unit tests for your solution. Include at least this coverage:
  - Words are divided by their first letter.
  - Words that start with an uppercase letter and lowercase letter are treated the same.
  - Files are created when they are needed.
  - Existing files are appending to.
  - ...
  - ?? can a unit test verify you are closing connections ??
