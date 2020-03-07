# _Word Counter_

#### _A C# Console Application that counts word occurrences in a phrase, March 2020_

#### By _**K. Wicz**_


## Description

_Word Counter gathers both a word and a phrase or sentence from a user, then returns the number of times the given word occurs within the given sentence._


## Project Specifications

| Behavior | Input | Output |
|:---|:---:|:---:|
|User begins program by inputting two strings: a word and a phrase.| "world", "Hello world"| program creates new instance of user input|
|User inputs a word which doesn't occur in the inputted phrase an program returns number of occurances.|"universe", "Hello world"| 0 |
|User inputs a word which occurs in a phrase once and program returns number of occurances. | "world", "Hello world" | 1 |
|User inputs word that is part of another word in the phrase and program does not count it as an occurance. | "cat", "My cat is going to the cathedral"| 1 |
|User inputs word and a phrase containing the word in a different case| "cat", "My cat Cat is going to the cathedral"| 2 |
|User inputs contain punctuation and the punctuation is replaced with " " |"cat", "My cat, named Cat, my other cat, named Monkey, and my dog, also named Cat, went to the cathedral."| "My cat  named Cat  my other cat  named Monkey  and my dog  also named Cat  went to the cathedral " |


## Setup/Installation Requirements

In your computer's terminal:

1. Navigate to where you want this application to be saved, i.e.:
```sh
cd desktop
```
2. Clone the file from GitHub with HTTPS
```sh
git clone 
```
3.  Enter into the new file directory
```sh
cd wordcounter.solutions
```
4.  Start the program
```sh
dotnet run
```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kwicz/wordcounter.solutions/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* MSTest
* C# Template Generator by Dusty McCord and Patrick Kille

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_K.Wicz_**