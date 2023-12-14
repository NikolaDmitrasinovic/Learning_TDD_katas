BOWLING

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

Solution (TDD way):
	Test for:
- "Gutter Game" ( game with the result of 0 )
- the game where all rolls are 1
- one spare in a game
- one strike in a game
- perfect game ( all rolls are 10s ) - should auto-pass

CALCULATE STATISTICS

Process a sequence of integer numbers to determine the following statistics:
* minimum value
* maximum value
* number of elements in the sequence
* average value

HUMAN READABLE TIME

Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
- HH = hours, padded to 2 digits, range: 00 – 99
- MM = minutes, padded to 2 digits, range: 00 – 59
- SS = seconds, padded to 2 digits, range: 00 – 59
The maximum time never exceeds 359_999 (99:59:59).

Solution (TDD way):
	Assert for:
		- 0 ( minimal valid input, no need to test for negative values as it is handled naturally during the implementation process )
		- 5
		- 60 ( implementing minutes )
		- 86_399
		- 359_999 ( maximum valid value )
		- any value greater than valid maximum 
