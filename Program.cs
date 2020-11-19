/*#########################################################################################################################################
Question 1
Cinema Entry Problem
A  program which decides whether or not a particular person is allowed to go and see a film is required. 
If the age of the user and the film match up the program will print:
"Enjoy the film" otherwise it will print out "Access Denied - You are too young". 
The program  will print a menu of films from which the user will choose the one they want to see. 
The user will then enter their age. The program will be used like this:

Welcome to our Sligo Multiplex

We are presently showing:
    1. Made in Dagenham (15)
    2. Buried (18)
    3. Despicable Me (U)
    4. The Other Guys (12A)
    5. Takers (12A)
Enter the number of the film you wish to see: 1
Enter your age: 12
Access denied – you are too young

Your program will have to read and store the number of the required film. It will then read and store the age. 
You must then use an appropriate arrangement of conditions to decide whether or not the customer can see the film.

Name: JamesMcDaid
Student No: S00200889
Date: 18/11/2020
Method: Year 1; Semester 1 Lab7 Q1:
Notes and prefix:   I am aware that this question could be done alot easier with arreays but
                    we have not be taught arreays and are limited to just "if" and "while statemnts".
                    The lecture is  not looking for the user input by the user to be checked or invailid.
                    The lecture did not require an option for checking multiple films at once.
                    I am aware that this code is messy and may be difficult to read but i would greatly apprciate feedback on
                    how messy my code is and whether or not the logic can be followed.

#   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   #   


                TO WHOM EVER IS MAD OR BORED ENOUGH TO REVIEW THIS CODE FOR KICKS: THANK YOU

 
 ##################################################################################################################################*/
using System;

namespace Lab7q1
{
    class Program
    {
        static void Main(string[] args)
        {

            //dispaly the movie options

            Console.WriteLine("We are presently showing:");
            Console.WriteLine("     1. Made in Dagenham     (15)");
            Console.WriteLine("     2. Buried               (18)");
            Console.WriteLine("     3. Despicable Me        (U)");
            Console.WriteLine("     4. The Other Guys       (12A)");
            Console.WriteLine("     5. Takers               (12A)");

            //user selction
            //how many films are they gonna watch
            Console.WriteLine("Enter the number of the film you wish to see(up to 5):");
            var userInput1 = Console.ReadLine();
            var userInput1Valid = int.TryParse(userInput1, out int numberOfFilmsSeen); // if its a number its a number
            while (userInput1Valid == false || numberOfFilmsSeen >5 || numberOfFilmsSeen < 1)
            {
                Console.WriteLine("Enter the NUMBER of the films you wish to see(up tp 5):");
                userInput1 = Console.ReadLine();
                userInput1Valid = int.TryParse(userInput1, out numberOfFilmsSeen);
            }
            //decleartions for choice selection
            int numberOfFilmsSeenOutput = numberOfFilmsSeen;
            string movie1Name = "madeindagenham";
            string movie2Name = "buried";
            string movie3Name = "despicableme";
            string movie4Name = "theotherguys";
            string movie5Name = "takers";
            int numberOfFilms = 1;
            string firstFilmToCheck = "";
            string secondFilmToCheck = "";
            string thirdFilmToCheck = "";
            string forthFilmToCheck = ""; 
            string fifthFilmToCheck = "";
            while (numberOfFilmsSeen > 0)
            {

                Console.WriteLine("Please enter film {0}(number or name):", numberOfFilms);
                var film = Console.ReadLine();
                int.TryParse(film, out int filmNumber); //if they enter the number of the film the film number is set
                string filmCast = film;  //setting up the casting to check the name of the film
                filmCast = filmCast.ToLower();
                filmCast = filmCast.Replace("_", "");
                filmCast = filmCast.Replace(" ", "");
                filmCast = filmCast.Replace("-", "");

                //checking if the input is a movie name
                bool filmCastIsMovieName = (filmCast == movie1Name) || (filmCast == movie2Name) || (filmCast == movie3Name) || (filmCast == movie4Name) || (filmCast == movie5Name);
                
               while (filmCastIsMovieName == false && (filmNumber < 1 || filmNumber > 5)) 
                {
                    Console.WriteLine("Incorrect Input. Please enter film {0}(number or name):", numberOfFilms);
                    film = Console.ReadLine();
                    int.TryParse(film, out filmNumber); //if they enter the number of the film the film number is set
                    filmCast = film;  //setting up the casting to check the name of the film
                    filmCast = filmCast.ToLower();
                    filmCast = filmCast.Replace("_", "");
                    filmCast = filmCast.Replace(" ", "");
                    filmCast = filmCast.Replace("-", "");
                    //cecking if the input is a movie name
                    filmCastIsMovieName = (filmCast == movie1Name) || (filmCast == movie2Name) || (filmCast == movie3Name) || (filmCast == movie4Name) || (filmCast == movie5Name);
                }
                
               //sets the movie they want to see 
                if (numberOfFilms == 1)
                {
                    
                    if (filmNumber == 1)
                    {
                        firstFilmToCheck = movie1Name;
                    }
                    else
                    if (filmNumber == 2)
                    {
                        firstFilmToCheck = movie2Name;
                    }
                    else
                    if (filmNumber == 3)
                    {
                        firstFilmToCheck = movie3Name;
                    }
                    else
                    if (filmNumber == 4)
                    {
                        firstFilmToCheck = movie4Name;
                    }
                    else
                    if (filmNumber == 5)
                    {
                        firstFilmToCheck = movie5Name;
                    }
                    else
                    {
                        firstFilmToCheck = filmCast;
                    }
                    
                }
                if (numberOfFilms == 2)
                {
                    
                    if (filmNumber == 1)
                    {
                        secondFilmToCheck = movie1Name;
                    }
                    else
                    if (filmNumber == 2)
                    {
                        secondFilmToCheck = movie2Name;
                    }
                    else
                    if (filmNumber == 3)
                    {
                        secondFilmToCheck = movie3Name;
                    }
                    else
                    if (filmNumber == 4)
                    {
                        secondFilmToCheck = movie4Name;
                    }
                    else
                    if (filmNumber == 5)
                    {
                        secondFilmToCheck = movie5Name;
                    }
                    else
                    {
                        secondFilmToCheck = filmCast;
                    }


                }
                if (numberOfFilms == 3)
                {
                    
                    if (filmNumber == 1)
                    {
                        thirdFilmToCheck = movie1Name;
                    }
                    else
                    if (filmNumber == 2)
                    {
                        thirdFilmToCheck = movie2Name;
                    }
                    else
                    if (filmNumber == 3)
                    {
                        thirdFilmToCheck = movie3Name;
                    }
                    else
                    if (filmNumber == 4)
                    {
                        thirdFilmToCheck = movie4Name;
                    }
                    else
                    if (filmNumber == 5)
                    {
                        thirdFilmToCheck = movie5Name;
                    }
                    else
                    {
                        thirdFilmToCheck = filmCast;
                    }
                }
                if (numberOfFilms == 4)
                {
                    
                    if (filmNumber == 1)
                    {
                        forthFilmToCheck = movie1Name;
                    }
                    else
                    if (filmNumber == 2)
                    {
                        forthFilmToCheck = movie2Name;
                    }
                    else
                    if (filmNumber == 3)
                    {
                        forthFilmToCheck = movie3Name;
                    }
                    else
                    if (filmNumber == 4)
                    {
                        forthFilmToCheck = movie4Name;
                    }
                    else
                    if (filmNumber == 5)
                    {
                        forthFilmToCheck = movie5Name;
                    }
                    else
                    {
                        forthFilmToCheck = filmCast;
                    }
                }
                if (numberOfFilms == 5)
                {
                    
                    if (filmNumber == 1)
                    {
                        fifthFilmToCheck = movie1Name;
                    }
                    else
                    if (filmNumber == 2)
                    {
                        fifthFilmToCheck = movie2Name;
                    }
                    else
                    if (filmNumber == 3)
                    {
                        fifthFilmToCheck = movie3Name;
                    }
                    else
                    if (filmNumber == 4)
                    {
                        fifthFilmToCheck = movie4Name;
                    }
                    else
                    if (filmNumber == 5)
                    {
                        fifthFilmToCheck = movie5Name;
                    }
                    else
                    {
                        fifthFilmToCheck = filmCast;
                    }
                }
                // change the counters and loop back for 2nd/3rd/4th/5th eneteris
                numberOfFilmsSeen--;
                numberOfFilms++;


            }
            //get the users age
            Console.WriteLine("Please enter your age:");
            var userEntery = Console.ReadLine();
            bool userEnteryValid = int.TryParse(userEntery, out int age);
            while (userEnteryValid == false) //making sure its an actual number
            {
                Console.WriteLine("Please enter your age(as a number):");
                userEntery = Console.ReadLine();
                userEnteryValid = int.TryParse(userEntery, out age);
            }
            //declartions to calulate if the age matches the film age limit
            int limitone = 0;
            int limitTwo = 0;
            int limitThree = 0;
            int limitFour = 0;
            int limitFive = 0;
            int filmONELimit = 15;
            int filmTwoLimit = 18;
            int filmThreeLimit = 4;
            int filmFourLimit = 12;//check if adult is with if less than 12(optional extra to work on)
            int filmFiveLimit = 12;
            //first movie age limit
            if (firstFilmToCheck == movie1Name)
            {
                limitone = filmONELimit;
            }
            if (firstFilmToCheck == movie2Name)
            {
                limitone = filmTwoLimit;
            }
            if (firstFilmToCheck == movie3Name)
            {
                limitone = filmThreeLimit;
            }
            if (firstFilmToCheck == movie4Name)
            {
                limitone = filmFourLimit;
            }
            if (firstFilmToCheck == movie5Name)
            {
                limitone = filmFiveLimit;
            }
            //secound movie age limit
            if (secondFilmToCheck == movie1Name)
            {
                limitTwo = filmONELimit;
            }
            if (secondFilmToCheck == movie2Name)
            {
                limitTwo = filmTwoLimit;
            }
            if (secondFilmToCheck == movie3Name)
            {
                limitTwo = filmThreeLimit;
            }
            if (secondFilmToCheck == movie4Name)
            {
                limitTwo = filmFourLimit;
            }
            if (secondFilmToCheck == movie5Name)
            {
                limitTwo = filmFiveLimit;
            }
            //third movie age limit
            if (thirdFilmToCheck == movie1Name)
            {
                limitThree = filmONELimit;
            }
            if (thirdFilmToCheck == movie2Name)
            {
                limitThree = filmTwoLimit;
            }
            if (thirdFilmToCheck == movie3Name)
            {
                limitThree = filmThreeLimit;
            }
            if (thirdFilmToCheck == movie4Name)
            {
                limitThree = filmFourLimit;
            }
            if (thirdFilmToCheck == movie5Name)
            {
                limitThree = filmFiveLimit;
            }
            //forth movie age limit
            if (forthFilmToCheck == movie1Name)
            {
                limitFour = filmONELimit;
            }
            if (forthFilmToCheck == movie2Name)
            {
                limitFour = filmTwoLimit;
            }
            if (forthFilmToCheck == movie3Name)
            {
                limitFour = filmThreeLimit;
            }
            if (forthFilmToCheck == movie4Name)
            {
                limitFour = filmFourLimit;
            }
            if (forthFilmToCheck == movie5Name)
            {
                limitFour = filmFiveLimit;
            }
            //fifth movie age limit
            if (fifthFilmToCheck == movie1Name)
            {
                limitFive = filmONELimit;
            }
            if (fifthFilmToCheck == movie2Name)
            {
                limitFive = filmTwoLimit;
            }
            if (fifthFilmToCheck == movie3Name)
            {
                limitFive = filmThreeLimit;
            }
            if (fifthFilmToCheck == movie4Name)
            {
                limitFive = filmFourLimit;
            }
            if (fifthFilmToCheck == movie5Name)
            {
                limitFive = filmFiveLimit;
            }
            //Display the out depending on if the age is right
            //output choice 1
            if (age >= limitone && numberOfFilmsSeenOutput >0)
            {
                Console.WriteLine("You are old enough to watch the first film selected");
            }
            if (age < limitone && numberOfFilmsSeenOutput > 0)
            {
                Console.WriteLine("You aren't old enough to watch the first film selected");
                Console.WriteLine("Access denied – you are too young.");
            }
            //output choice 2
            if (age >= limitTwo && numberOfFilmsSeenOutput > 1)
            {
                Console.WriteLine("You are old enough to watch the second film selected");
            }
            if (age < limitTwo && numberOfFilmsSeenOutput > 1)
            {
                Console.WriteLine("You aren't old enough to watch the second film selected");
                Console.WriteLine("Access denied – you are too young.");
            }
            //output choice 3
            if (age >= limitThree && numberOfFilmsSeenOutput > 2)
            {
                Console.WriteLine("You are old enough to watch the third film selected");
            }
            if (age < limitThree && numberOfFilmsSeenOutput > 2)
            {
                Console.WriteLine("You aren't old enough to watch the third film selected");
                Console.WriteLine("Access denied – you are too young.");
            }
            //output choice 4
            if (age >= limitFour && numberOfFilmsSeenOutput > 3)
            {
                Console.WriteLine("You are old enough to watch the forth film selected");
            }
            if (age < limitFour && numberOfFilmsSeenOutput > 3)
            {
                Console.WriteLine("You aren't old enough to watch the forth film selected");
                Console.WriteLine("Access denied – you are too young.");
            }
            //output choice 5
            if (age >= limitFive && numberOfFilmsSeenOutput > 4)
            {
                Console.WriteLine("You are old enough to watch the fifth film selected");
            }
            if (age < limitFive && numberOfFilmsSeenOutput > 4)
            {
                Console.WriteLine("You aren't old enough to watch the fifth film selected");
                Console.WriteLine("Access denied – you are too young.");
            }
        }
    }
}