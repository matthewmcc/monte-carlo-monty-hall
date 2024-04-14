# Monte Carlo Monty Hall simulator

This application simulates the 
[Monty Hall problem](https://en.wikipedia.org/wiki/Monty_Hall_problem) using the Monte Carlo method.

In a nut shell. When a player initially chooses a door containing a goat, the host reveals the 
location of the other goat behind one of the remaining doors. By switching 
their choice, the player effectively shifts their odds to select the door 
concealing the car. Since there's a 2/3 probability of picking a goat 
initially, there's also a 2/3 likelihood of selecting the car by switching 
doors.

At first when given the problem and the chances of success this seems 
illogical. Which is the crux of the problems popularity.


To run the console application. Run the dev container then the following 
commands in the terminal.

```cmd
dotnet build
dotnet run --project MontyHallConsoleApp