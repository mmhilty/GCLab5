using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the variable and then fill it with userinput converted to long
            while(true)
                {
                long userNumber;

                Console.WriteLine("Enter a number between 1 and 20 to get its factorial: ");
                try
                {
                    userNumber = Convert.ToInt64(Console.ReadLine());

                    if (userNumber > 0 && userNumber <= 20)
                    {

                        long userFactorial = ReturnFactorial(userNumber);

                        Console.WriteLine(userFactorial);

                        //continue area
                        contGoTo:
                        Console.WriteLine("Continue? y/n");
                        string userChoice = Console.ReadLine();
                        if (userChoice.ToLower() == "y")
                        {
                            continue;
                        }

                        else if(userChoice.ToLower() == "n")
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("What?");
                            goto contGoTo;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No.");
                        continue;
                    }
                }

                catch
                {
                    Console.WriteLine("No.");
                    continue;
                }

            }
        }

        static long ReturnFactorial(long userNumber)
        {
            //userNumber exists in here locally and is currently = to the input 
            
                if (userNumber == 0)
                {
                    return 1;
                }

                else
                {
                    return userNumber * ReturnFactorial(userNumber - 1);
                }
                     
        }

    }
}
