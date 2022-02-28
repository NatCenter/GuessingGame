using System;


//Console.WriteLine($" your guess was: {guess}");


int secretNumber=42;
// phase 3
int tries=4;
int guessNumber=1;
while (guessNumber<=tries){
    //phase 4
    Console.WriteLine($"Your guess - {guessNumber}");
    //phase   1

    Console.WriteLine("User needs to guess the right number");
int guess=int.Parse(Console.ReadLine());
//phase 2
if (guess==secretNumber){
    Console.WriteLine("You guess right!");
    break;
}
else {
    Console.WriteLine("Sorry you are wrong!");
    
}
//phase 4
guessNumber++;
}

