using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            String retry;
            
            int guesses, number, levelselected, Guessednumber; 
/*
            guesses: The number of guesses that the user has
            
            number: is the specified Number ranges in each level
            
            levelselected: The Different levels of the game Easy, Medium and Hard 
            I declared it as an interger so i can use the Switch statement to take it to the Code for each of the levels

            GuessedNumber: Stores the number the user enter to check if the user is correct
            */

            Console.Write("Please Enter your name: ");
            String name = Console.ReadLine();//Stores the users name
            
            Difficulty:
            Console.WriteLine("Welcome {0}, Please Select a difficulty: " , name);
            Console.WriteLine("Enter 1 for Easy");
            Console.WriteLine("Enter 2 for Medium");
            Console.WriteLine("Enter 3 for Hard");

            levelselected = int.Parse(Console.ReadLine());

            switch (levelselected)
            {
                case 1:
                Console.WriteLine("You have 6 Guesses");
                     goto Easy;
                break;

                case 2:      
                Console.WriteLine("You have 4 Guesses");             
                    goto Medium;
                break;

                case 3:
                Console.WriteLine("You have 3 Guesses");
                    goto Hard;
                break;

                default:
                Console.WriteLine("Please chooose a level");
                break;

            }
//Code For Easy Difficulty
            Easy:
             number = r.Next(1, 10);
              guesses = 6;
            
           do
           {
            Console.Write("Guess a number between 1-10: ");
            Guessednumber = int.Parse(Console.ReadLine());  
            if (Guessednumber == number)
                    {
                        Console.Write("You got it right!");
                        break;
                    }else
                    {
                       Console.WriteLine("That was wrong");
                       guesses--;
                        Console.WriteLine("You have {0} Guesses left ", guesses);
                    } 
           } while (guesses != 0);
           if (guesses == 0)
           {
                Console.WriteLine("Game Over!!");
                
           }

           Console.WriteLine("Do you want to play again:");
           Console.WriteLine("Enter yes or no");
             retry = Console.ReadLine();
           if ((retry == "y") || (retry == "yes")){
               goto Difficulty;
           }else
           {
               goto Finish;
           }
//Code For Medium Difficulty
           Medium:
                 number = r.Next(1, 20);
                    guesses = 4;
                    do
           {
            Console.Write("Guess a number between 1-20: ");
            Guessednumber = int.Parse(Console.ReadLine());  
            if (Guessednumber == number)
                    {
                        Console.Write("You got it right!");
                        break;
                    }else
                    {
                       Console.WriteLine("That was wrong");
                       guesses--;
                        Console.WriteLine("You have {0} Guesses left ", guesses);
                    } 
           } while (guesses != 0);
           if (guesses == 0)
           {
                Console.WriteLine("Game Over!!");
           }
             Console.WriteLine("Do you want to play again:");
           Console.WriteLine("Enter yes or no");
            retry = Console.ReadLine();
           if ((retry == "y") || (retry == "yes")){
               goto Difficulty;
           }else
           {
               goto Finish;
           }
//Code For Hard Difficulty
           Hard:            
                    number = r.Next(1, 50);
                    guesses = 3;
           do
           {
            Console.Write("Guess a number between 1-50: ");
            Guessednumber = int.Parse(Console.ReadLine());  
            if (Guessednumber == number)
                    {
                        Console.Write("You got it right!");
                        break;
                    }else
                    {
                       Console.WriteLine("That was wrong");
                       guesses--;
                        Console.WriteLine("You have {0} Guesses left ", guesses);
                    } 
           } while (guesses != 0);
           if (guesses == 0)
           {
                Console.WriteLine("Game Over!!");
           }
             Console.WriteLine("Do you want to play again:");
           Console.WriteLine("Enter yes or no");
            retry = Console.ReadLine();
           if ((retry == "y") || (retry == "yes")){
               goto Difficulty;
           }else
           {
               goto Finish;
           }

           Finish:
           Console.WriteLine("Thank you for playing");
    }
}
}