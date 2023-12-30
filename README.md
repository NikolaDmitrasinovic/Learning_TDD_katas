--------
BOWLING
--------
Write a class named “Game” that has two methods:
- roll(pins : int) is called each time the player rolls a ball.  The argument is the number of pins knocked down.
- score() : int is called only at the very end of the game.  It returns the total score for that game.

Game rules:
- 10 frames
- each frame player has up to 2 balls to knock down 10 pins
- score for the frame is total number of knocked pins, plus bonuses for strikes and spares
- spare - when 10 pins are knocked in two tries. Bonus: add number of knocked pines from the next roll
- strike - when 10 pins are knocked on first try. Bonus: number of knocked pines in next 2 rolls
- in 10th frame a spare or a strike earns extra balls, but no more than 3 balls can be rolled altogether

Solve by testing for:
- "Gutter Game" ( game with the result of 0 )
- the game where all rolls are 1
- one spare in a game
- one strike in a game
- perfect game ( all rolls are 10s ) - should auto-pass
---------------------
CALCULATE STATISTICS
---------------------
Process a sequence of integer numbers to determine the following statistics:
* minimum value
* maximum value
* number of elements in the sequence
* average value
------------
EVEN OR ODD
------------
Given an array of numbers, determine whether the sum of all of the numbers is odd or even.
Give your answer in string format as [odd] or [even]. If the input array is empty consider it as \[0] ( array with a zero ).

Example:
* OddOrEven(\[0]) returns "even"
* OddOrEven(\[2, 5, 34, 6]) returns "odd"
* OddOrEven(\[0, -1, -5]) returns "even"
---------
FizzBuzz
---------
Write a program ( using TDD ) that prints the numbers from 1 to 100. But for multiples of three print "Fizz" and for multiples of five print "Buzz". For numbers which are multiples of both print "FizzBuzz".

Sample output: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 ... etc

--------------------
HUMAN READABLE TIME
--------------------
Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
- HH = hours, padded to 2 digits, range: 00 – 99
- MM = minutes, padded to 2 digits, range: 00 – 59
- SS = seconds, padded to 2 digits, range: 00 – 59
The maximum time never exceeds 359_999 (99:59:59).

Solve by testing for:
- 0 ( minimal valid input, no need to test for negative values as it is handled naturally during the implementation process )
- 5
- 60 ( implementing minutes )
- 86_399
- 359_999 ( maximum valid value )
- any value greater than valid maximum
----------
LEAP YEAR
----------
Write a function that returns true or false depending on whether its input integer is a leap year or not.

A leap year is divisible by 4 but is not otherwise divisible by 100 unless it is also divisible by 400.

Test examples: 
* 2001 typical common year
* 1996 typical leap year
* 2000 atypical leap year
* 1900 atypical common year
----------------
LIST COMPARATOR
----------------
You have two arrays in this kata, every array contains only unique elements. Your task is to calculate the number of elements in the first array which are also in the second array.
--------------
PRIME FACTORS
--------------
Write a class named “PrimeFactors” that has one static method: generate.

The generate method takes an integer argument and returns a List. That list contains the prime factors in numerical sequence.

For example:
- 100 should return 2, 2, 5, 5
- 2 should return 2
- Smaller than 2 should return an empty list
------
Queue
------
Implement your own queue (existing .NET implementations are not allowed (list, array, …)).

- The queue should have the following methods:
- Enqueue(object): Adds an element to the queue.
- Dequeue(): Returns the first element and removes it from the queue.
- Peek(): Returns the first element without removing it.
------------------
STRING CALCULATOR
------------------
Create StringCalculator class with int Add(string numbers) method
* The method can take up to two numbers separated by commas and will return their sum
	Example: "" or "1" or "1,2"
* For an empty string it will return 0

* Allow the Add method to handle an unknown amount of numbers
* Allow the Add method to handle new lines between numbers
	Example: "1\\n2,3" will equal 6
* Support different delimiters, but they are optional ( "//\[delimiter]\\n\[numbers]" )
	Example: "//;\\n1;2"
* Calling Add with a negative number will throw an exception "negatives not allowed" and the negative that was passed, all of them in case of multiple

Continue if you can finish previous steps in less than 30 minutes.

* Numbers bigger than 1000 should be ignored ( 2 + 1001 = 2 )
* Delimiters can be of any length in format of "//\[delimiter]\\n"
	Example: "//\[\*\*\*]\\n1\*\*\*2\*\*\*3*"
* Allow multiple delimiters like "//\[delimiter1]\[delimiter2]\\n"
	Example: "//\[\*]\[&]\\n1\**2&3"
* Make sure you can also handle multiple delimiters with length longer than one char
-------
TENNIS
-------
Implement a simple tennis game.
Game Rules:
* A game is won by the first player to have won at least four points in total and at least two points more than the opponent
* Points from 0 to 3 are described: "love", "15", "30", "40"
* if at least three points have been scored by each player, and the scores are equal, the score is "deuce"
* if at least three points have been scored by each player, and one side has one pint more than the opponent, that player has an "advantage"

Match Rules:
* There are [best of 3] and [best of 5] matches in terms of sets
* To win a set player must win at least 6 games, and have at least two games lead against the opponent
* If both player have 6 games won the [tie braker] is played 
-------------
WORD WRAPPER
-------------
You write a class called Wrapper, that has a single static function named wrap that takes two arguments, a string, and a column number. The function returns the string, but with line breaks inserted at just the right places to make sure that no line is longer than the column number. You try to break lines at word boundaries.

Like a word processor, break the line by replacing the last space in a line with a newline.
