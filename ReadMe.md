# Word Frequency Counter



## Description

_This project will take a word and check to see how many times that word appears in a sentence_


### Installing

To run this file open a terminal window and navigate to the WordCounter.Solution folder. Navigate to the WordCounter subdirectory and run the command ``` mono Program.exe ``` to run the program.

## Running the tests

Test methods and methods in the production code are commented out as they have all been refactored into one method. To observe the functioning tests you need to uncomment out the test methods in the WordCounter.Test.cs file and the corresponding methods in the WordCounter.cs file.

Navigate to the WordCounter.Test subdirectory, run ``` dotnet test ``` in the console to observe if the test methods pass or fail.

### Break down into end to end tests
## Business logic tests

_Behavior 1_
* Can create a new WordFrequencyCounter object

_Behavior 2_
* Can correctly capture a letter and return the letter if it is a match to the same letter
* Input: a
* Output: a
* Note: This behavior was refactored into the WordCounter() method after the test passed.

_Behavior 3_
* Can correctly capture and return a sentence.
* Input: "Hello this is a sentence"
* Output: "Hello this is a sentence"
* Note: This behavior was refactored into the WordCounter() method after the test passed.

_Behavior 4_
* Can split sentence into a list of words
* Input: "Hello this is a sentence"
* Output {"Hello", "this", "is", "a", "sentence"}
* Note: This behavior was refactored into the WordCounter() method after the test passed.

_Behavior 5_
* Can count the instances of one letter in an array
* Input: Word = a // Sentence = "Look at a word that a user can enter"
* Output: count = 2
* Note: This behavior was refactored into the WordCounter() method after the test passed.

_Behavior 6_
* Can count the instances of an entire word in a sentence testArray
* Input: Word = Hello // sentence = "Hello there said the cheery man saying hello"
* Output: count = 2

_Behavior 7_
* Will change all letters to lower case for more specific comparing
* Input: Hello
* Output: hello
* Note: This behavior was refactored into the WordCounter() method after the test passed.

_Behavior 8_
* Program should be able to split at white space and special characters.
* Input: Hello, my name is Joel.
* Output: {"Hello", "my", "name", "is", "Joel"}
* Note: This behavior was refactored into the WordCounter() method after the test passed.

---------------------------------------------------------------------------------------------------------


## Built With

* .NET framework
* MSTest
* Mono


## Authors

* **Chris Rudnicky**

## License

This project is licensed under the MIT License

## Acknowledgments

This project was built with inspiration found from:

* Basic idea for how to count words in a text file found here: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/how-to-count-occurrences-of-a-word-in-a-string-linq
* Learned how to split a string based off of specific characters here:
https://www.dotnetperls.com/split
https://www.c-sharpcorner.com/UploadFile/mahesh/split-string-in-C-Sharp/
* Learned about delimiter splitting here:
https://docs.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
* Epicodus C# Week 1 lessons on Basic Console Apps and testing:
https://www.learnhowtoprogram.com/c
