using System;
//phase 1
Console.WriteLine("User needs to guess the right number");
int guess=int.Parse(Console.ReadLine());
//Console.WriteLine($" your guess was: {guess}");
//phase 2

int secretNumber=42;

if (guess==secretNumber){
    Console.WriteLine("You guess right!");
}
else {
    Console.WriteLine("Sorry you are wrong!");
}
