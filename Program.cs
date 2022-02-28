using System;


//Console.WriteLine($" your guess was: {guess}");


int secretNumber=42;
// phase 3
int tries=4;
while (tries>0){
    //phase 1
    Console.WriteLine("User needs to guess the right number");
int guess=int.Parse(Console.ReadLine());
//phase 2
if (guess==secretNumber){
    Console.WriteLine("You guess right!");
}
else {
    Console.WriteLine("Sorry you are wrong!");
}
tries--;
}

