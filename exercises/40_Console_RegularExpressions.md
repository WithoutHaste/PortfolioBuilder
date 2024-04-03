# 40 Console: Regular Expressions

**Purpose**: This exercise will show that you can use regular expressions.

**Requirements**:  
- Use regular expressions to write the functions that satisfy the provided use cases.
- Write unit tests based on the provided use cases.

**IsPhoneNumber Test Cases**  
| Input | Expected Result |
| ----- | --------------- |
| 123.456.7890 | True |
| 999.888.7777 | True |
| 726.938.9910 | True |
| 123-456-7890 | True |
| 000-777-6666 | True |
| 217-238-5352 | True |
| (123) 456-7890 | True |
| (222) 111-8888 | True |
| (748) 009-8244 | True |
| 1234567890 | True |
| 8888888888 | True |
| 3875284653 | True |
| (123) 4567890 | False |
| (123) 456.7890 | False |
| 123456789 | False |
| 123456.7890 | False |
| 12-3-456-7890 | False |
| 123.456.78901 | False |
| 1b3-456-7890 | False |
| 123 456 7890 | False |

**IsEmailAddress Test Cases**  
| Input | Expected Result |
| ----- | --------------- |
| a@b.c | True |
| A@B.C | True |
| apple@banana.com | True |
| apple.pear@banana.com | True |
| apple+pear@banana.com | True |
| apple-pear@banana.com | True |
| apple_pear@banana.com | True |
| apple@banana-cherry.com | True |
| a123456@b7890.c | True |
| 1a@b.c | False |
| a@2b.c | False |
| @b.c | False |
| a@.c | False |
| a@b. | False |
| a.@b.c | False |
| a+@b.c | False |
| a-@b.c | False |
| a_@b.c | False |
| a..z@b.c | False |
| .a@b.c | False |
| +a@b.c | False |
| -a@b.c | False |
| a@b@c | False |
| a@b-.c | False |

**EvaluateExpression Test Cases**  
| Input | Expected Result |
| ----- | --------------- |
| 2+4 | 6 |
| 2 +7 | 9 |
| 3+ 12 | 15 |
| 11 + 9 | 20 |
| 2-4 | -2 |
| 8 -7 | 1 |
| 20- 2 | 18 |
| 3 - 16 | -13 |

**ReorderColumns Test Cases**  
(use capture groups to reorder columnar data)  
| Input | Expected Result |
| ----- | --------------- |
| John,34,:),TX | :),John,TX,34 |
| Sarah Jane,9,!,MN | !,Sarah Jane,MN,9 |
| bob,101,XD,WA | XD,bob,WA,101 |

