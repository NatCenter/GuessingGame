﻿using System;

//phase 5
int secretNumber=new Random().Next(1,100);



// phase 3
int tries=4;
int guessNumber=1;
while (guessNumber<=tries){
    //phase 4
    Console.WriteLine($"Your guess  {guessNumber} out of 4");
   
    //phase   1

    Console.WriteLine("Please guess the secret number");
int guess=int.Parse(Console.ReadLine());


//phase 2
if (guess==secretNumber){
    Console.WriteLine("You guess right!");
    break;
}
//Phase 6
else {
    if(guess<secretNumber){
        Console.WriteLine("Sorry you guessed too low!");

    }
    else {
        Console.WriteLine("Sorry you guessed too high!");
    }
    
    // Phase 5
     if(tries-guessNumber==1)
     {  
         Console.WriteLine($"You have 1 guess remining");
     
     } else {
        Console.WriteLine($"You have {tries-guessNumber} tries");
     }
    
}
//phase 4
guessNumber++;
}

