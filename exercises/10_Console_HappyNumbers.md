# 10 Console: Happy Numbers

**Purpose**: This exercise will show that you can use flow controls, functions, simple data structures, and (very important) unit tests.

**Requirements**:  
- Output all the happy numbers from 1 to 100.
- Write unit tests of your "happy number" generator. Include at least this test coverage:
  - Test for numbers that should be happy.
  - Test for numbers that should be unhappy.
  - Test for invalid inputs.

**Happy Numbers**: A happy number is a positive integer that will result in 1 if you repeat this step often enough: starting from number N, calculate the sum of the squares of each digit of N.  
> *Example: 103 leads to 10 because 1x1 + 0x0 + 3x3 = 10*  
> *103 is a happy number because 103 -> 10 -> 1*  
> *20 is an unhappy number because it gets trapped in this loop: 4 -> 16 -> 37 -> 58 -> 89 -> 145 -> 42 -> 20 -> 4*  

All numbers will either reach 1 or end up in a loop.  
