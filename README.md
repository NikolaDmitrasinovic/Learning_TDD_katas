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
