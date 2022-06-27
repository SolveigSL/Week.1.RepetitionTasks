using System;
using System.Collections.Generic;

namespace Week._1.RepetitionTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //Oppgave 1 
            // Console.WriteLine("Hello World");

            // Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            // if (name == "Solveig")
            // {
            //     Console.WriteLine("Hey you!");
            // }

            // else
            // {
            //     for (int i = 0; i <= 10; i++)
            //     {
            //         Console.WriteLine(name);
            //     }

            // }

            //OPPGAVE 2
            //Console.WriteLine("Hello, please write your name");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");

            //Console.WriteLine("Type in two numbers");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //int numbersAdded = numberOne + numberTwo;   
            //Console.WriteLine($"{numberOne} + {numberTwo} = {numbersAdded}");

            //Console.WriteLine("Type in 3 numbers");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //int numberThree = Convert.ToInt32(Console.ReadLine());
            //int numbersAdded = numberOne + numberTwo + numberThree;
            //Console.WriteLine($"{numberOne} + {numberTwo} + {numberThree} = {numbersAdded}");

            //Console.WriteLine("Type in a decimal number. I am going to convert it to a whole number");
            //double decimalNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"The closest whole number to {decimalNumber} is {decimalNumber = Math.Round(decimalNumber,0)}");

            //OPPGAVE 3

            //Console.WriteLine("Er FKH Norges beste fotballag?\n1.Ja\n2:Nei");
            //string answer = Console.ReadLine();

            //if (answer == "ja")
            //{
            //    Console.WriteLine("BRA");
            //}

            //while (true)
            //{
            //    Console.WriteLine("Hva er temperaturen i Oslo?");
            //    int answerOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Hva er temperaturen i Haugesund");
            //    int answerTwo = Convert.ToInt32(Console.ReadLine());

            //    if (answerOne > answerTwo)
            //    {
            //        Console.WriteLine($"Det er varmere i Oslo fordi det er {answerOne} grader.\n");
            //    }
            //    else if (answerOne < answerTwo)
            //    {
            //        Console.WriteLine($"Det er varmere i Haugesund fordi der er der {answerTwo} grader\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Det er like varmt i både haugesund og Oslo\n");
            //        break;
            //    }

            //}

            //OPPGAVE 4

            //int teller = 0; 

            //while (teller < 20)
            //{

            //    teller++;
            //    Console.WriteLine(teller);
            //}

            //Console.WriteLine("Skriv inn et tall mellom 1 og 100");
            //int answer = Convert.ToInt32(Console.ReadLine());



            //if (answer < 1 || answer > 100)
            //{
            //    Console.WriteLine("Skriv inn et tall melom 1-100");
            //}

            //else
            //{
            //    while (answer > 1 || answer < 100)
            //    {

            //        answer++;

            //        Console.WriteLine(answer);

            //        if (answer > 99)
            //        {
            //            break;
            //        }
            //    }  
            //}

            //OPPGAVE 5

            try
            {
                Console.WriteLine("Skriv inn et tall mellom 1 og 100");
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer < 1 || answer > 100)
                {
                    Console.WriteLine("Skriv inn et tall melom 1-100");
                }

                while (answer > 1 && answer < 100)
                {

                    answer++;

                    Console.WriteLine(answer);

                    if (answer > 99)
                    {
                        break;
                    }
           }    }

            catch (Exception e)
            {
                Console.WriteLine("Feil tall");
  
            }
        }
          

            

















        


    }
}
