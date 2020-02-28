using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFarooqiA2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string menuInput;
            bool menuContinue = true;

            do
            {
                try
                {
                    Console.WriteLine("1. Enter triangle dimensions");
                    Console.WriteLine("2. Exit");

                    menuInput = Console.ReadLine();


                    if (menuInput == "2")
                    {
                        Environment.Exit(0);
                        menuContinue = true;
                    }

                    if (menuInput == "1")
                    {
                        try
                        {
                            Console.WriteLine("Please enter a 1st int");
                            int sideOne = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter a 2nd int");
                            int sideTwo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter a 3rd int");
                            int sideThree = int.Parse(Console.ReadLine());

                            if (TriangleSolver.Analyze(sideOne, sideTwo, sideThree) == "Side cannot be negative")
                            {
                                menuContinue = false;
                            }

                            if (TriangleSolver.Analyze(sideOne, sideTwo, sideThree) == "Side cannot be 0. Please try again")
                            {
                                menuContinue = false;
                            }

                            Console.WriteLine(TriangleSolver.Analyze(sideOne, sideTwo, sideThree));
                            menuContinue = false;


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Something went wrong: " + ex.Message);
                            menuContinue = false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please ONLY enter 1 or 2");
                        menuContinue = false;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error: " + ex.Message);
                    menuContinue = false;
                }


            } while (!menuContinue);
        }
    }
}
