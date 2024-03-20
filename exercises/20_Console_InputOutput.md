# 20 Console: Input/Output

**Purpose**: This exercise will show that you can take input from the user and respond to it.

**Requirements**:  
- Your program will play "Hotter/Colder" with the user
  - Select a random number from 1 to 100.
  - Prompt the user to guess a number in this range.
  - For the first guess, respond "Hot" when they are within 5 of the right number, respond "Warm" when they are within 20 of the right number, otherwise respond "Cold".
  - For subsequent guesses, respond based on the previous guess. "Warmer" when the guess is getting closer to the right number, and "Colder" when the guess is getting further from the right number. Add "Getting Hot!" to the "Warmer" response if they are within 5 of the right number.
  - Keep prompting the user to guess until they guess the correct number. Display "Correct!" as the success message.
- Write unit tests for your solution. Include at least this coverage:
  - Initial responses of "Hot", "Warm", "Cold", and "Correct!"
  - Subsequent responses of "Warmer", "Warmer, Getting Hot!", "Colder", and "Correct!"
  - Handling invalid inputs:
    - Something that is not an integer
	- An integer that is not in the range 1 to 100
