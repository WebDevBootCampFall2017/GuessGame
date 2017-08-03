using System;

namespace NumberGuessGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //I want to remember the username, so we create a var to hold it
            String player_name;
<<<<<<< HEAD
            Console.WriteLine("Welcome to the World Famous Guessing Game!");

            Console.WriteLine("Welcome to the World Famous Guessing game!");

            Console.WriteLine("What is your name contestent?");
            player_name = Console.ReadLine();
            Console.WriteLine("Lets roll the dice behind the screen, and see what number we get!");

            //Lets create our random var here
            //We can reuse this to get multiple random numbers
            Random r = new Random();

            //Lets mess with the user a bit
            int number_of_statements = (int)(r.NextDouble()*5.0);

            for (int i = 0; i < number_of_statements; i++){

                //This call will cause your program to wait for n milisecond before continuing!
                //Here n is 2000, which means 2 seconds
				System.Threading.Thread.Sleep(2000);
				
                //get random string
				int statement_number = (int)(r.NextDouble() * 5.0);
                switch (statement_number){
                    case 1:
                        Console.WriteLine("....*mumble* Oh Dear, that's too easy...");
                        break;
					case 2:
                        Console.WriteLine("....*mumble* Those aren't the loaded dice I wanted...");
						break;
					case 3:
                        Console.WriteLine("....*mumble* 42 again?!  I think this planet is trying to tell me something...");
						break;
					case 4:
                        Console.WriteLine("....*mumble* Yatzee!  Wait, wrong game...");
						break;
					case 5:
                        Console.WriteLine("....*mumble* 135?  How did I roll that on a D100...");
						break;
                }
            }

            System.Threading.Thread.Sleep(2000);
            int secret = (int)(r.NextDouble() * 100.0);

            Console.WriteLine("Great!  We have our number!  Now guess out of 100!");

            while (true){
                //our main game loop
                Console.WriteLine("What's your Guess?");
                String sGuess = Console.ReadLine();
                int iGuess = 0;

                //Try to parse the int
                if (!int.TryParse(sGuess, out iGuess)){
                    //We couldn't make a number
                    Console.WriteLine("Look, you have to guess a number.  No more funny Business!");
                    continue;
                }

                //Okay, we have a valid int, but we need to make sure it's in range
                if (iGuess >= 100 || iGuess < 0){
					Console.WriteLine("That's not how this works!  That's not how any of this works!  Guess again!");
					continue;
                }

                //Now we have a valid guess, lets give a hint
                if (iGuess < secret){
                    Console.WriteLine("Higher!");
                }

                if (iGuess > secret){
                    Console.WriteLine("Lower!");
                }

                if (iGuess == secret){
                    Console.WriteLine("Correct!  You're a winner!");
					Console.WriteLine("...Great, Now I can go home and nap!");
					Console.WriteLine("Shoo!  Game's over!  Go Away!");
                    Console.ReadKey();
                    break;
                }

            }
        }
    }
}
