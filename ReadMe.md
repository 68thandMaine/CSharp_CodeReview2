# Project Title

Word Frequency Counter

## Description

This project will take a word and check to see how many times that word appears in a sentance.


### Installing

In it's current state this program is meant to prove test methods. To run this file open the folder in the terminal and navigate to the WordCounter.Test subdirectory. Once inside, run ``` dotnet test ``` in the console to observe if the test methods pass or fail.

## Running the tests

Navigate to the WordCounter.Test subdirectory, run ``` dotnet test ``` in the console to observe if the test methods pass or fail.

### Break down into end to end tests
## Business logic tests

_Behavior 1_
Can create a new WordFrequencyCounter object

_Behavior 2_
Can correctly capture a letter and return the letter if it is a match to the same letter
Input: a
Output: a
Note: This behavior was refactored into the WordCounter() method after the test passed.

_Behavior 3_
Can correctly capture and return a sentence.
Input: "Hello this is a sentence"
Output: "Hello this is a sentence"
Note: This behavior was refactored into the WordCounter() method after the test passed.

_Behavior 4_
Can split sentence into a list of words
Input: "Hello this is a sentence"
Output {"Hello", "this", "is", "a", "sentence"}
Note: This behavior was refactored into the WordCounter() method after the test passed.

_Behavior 5_
Can count the instances of one letter in an array
Input: Word = a // Sentence = "Look at a word that a user can enter"
Output: count = 2
Note: This behavior was refactored into the WordCounter() method after the test passed.

_Behavior 6_
Can count the instances of an entire word in a sentence testArray
Input: Word = Hello // sentence = "Hello there said the cheery man saying hello"
Output: count = 2

_Behavior 7_
Will change all letters to lower case for more specific comparing
Input: Hello
Output: hello
Note: This behavior was refactored into the WordCounter() method after the test passed.

_Behavior 8_
Program should be able to split at white space and special characters.
Input: Hello, my name is Joel.
Output: {"Hello", "my", "name", "is", "Joel"}
Note: This behavior was refactored into the WordCounter() method after the test passed.

---------------------------------------------------------------------------------------------------------




## Built With

* .NET framework



## Authors

* **Chris Rudnicky** -

## License

This project is licensed under the MIT License

## Acknowledgments
