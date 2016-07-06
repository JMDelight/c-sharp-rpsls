# RSLPS

#### The game of Rock Scissors Lizard Paper Spock

#### By Joel Delight and Carl Egbert

## Description

Description

## Technologies Used

* C#
* Nancy and Razor View Engines
* XUnit

## Instructions

* Clone the repository
* In powershell, navigate to the project directory
* In powershell, enter '>dnu restore' and then '>dnx kestrel'.
* Navigate your web browser to http://localhost:5004

## BDD Specs

Behaviour | Input | Expected Output
----- | ----- | -----
Both players choose the same choice | Rock and rock| "Tie"
Player 1 chooses an option with value +1 compared to player 2 | Scissors and Rock | "Player 1 wins"
Player 1 chooses an option with value +2 compared to player 2 | Lizard and Rock | "Player 1 wins"
Player 2 chooses an option with value +1 compared to player 1 | Scissors and Rock | "Player 2 wins"
Player 2 chooses an option with value +1 compared to player 1 | Lizard and Rock | "Player 2 wins"
Players choose options with a difference greater than 2 | Rock and Spock | "Player 2 Wins"

## Known Bugs

None

## Contacts



### License

Licensed under the MIT License.

&copy;
