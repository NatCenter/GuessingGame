using System;
//phase 7
Console.WriteLine("Please pick a difficulty level: 1. Easy 2. Meduim 3.Hard 4. cheater");
int diffinalty=int.Parse(Console.ReadLine());
int tries=0;
bool cheater=false;
switch (diffinalty){
    case 1:
     tries=8;    
    break;
    case 2:
    tries=6;
    break;
    case 3:
    tries=4;
    break;
    //phase 9
    case 4:
    tries=10;
    cheater=true;
    break;
    //phase 8
    default:
    tries=1;
    break;
}
//phase 5
int secretNumber=new Random().Next(1,100);



// phase 3

int guessNumber=1;
while (guessNumber<=tries || cheater){
    //phase 4
    if(!cheater){

   // Phase 5
     if(tries-guessNumber==1)
     {  
         Console.WriteLine($"You have 1 guess remining");
     
     } else {
        Console.WriteLine($"You have {tries-guessNumber} tries");
     }
    
    
   }
   else {
       Console.WriteLine(" You have infinite guess left");
   }
    //phase   1

    Console.WriteLine("Please guess the secret number");
    int guess=int.Parse(Console.ReadLine());

//phase 2
    
if (guess==secretNumber){
    Console.WriteLine("You guess right!");
    cheater=false;
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
    
    
}
//phase 4
guessNumber++;
}

