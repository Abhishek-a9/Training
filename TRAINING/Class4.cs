using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsDemo
{

    // Program to play the Toung Twister Typing Game. As soon as the program is executed, it will prompt the user to complete the game within 15 seconds.
    //At level 1, the program will show a string. If the user types that string correctly, 
    //the program will take him/her to the next level and will again show a string.
    //On clearing this level the user will win the game. */


    public class GameEg
    {

        public void StartGame()
        {
            String str;
            str = "The Cheater Cheats the Cheating Code";
            String str1;
            str1 = "She Sells Sea Shells";// On The Sea Shore!";
            Console.WriteLine("Level 1: \n{0}", str);
            String userVal = Console.ReadLine();
            if (userVal == str)
            {
                Console.WriteLine("\nYou WON! Welcome to Level 2! \n");

                while (true)
                {

                    Console.WriteLine("Level 2: \n{0}", str1);
                    String userVal1 = Console.ReadLine();
                    if (userVal1 == str1)
                    {
                        Console.WriteLine("\nYou WON! Game Over! \n");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("\nThe strings do not match..Try Again! \n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nThe strings do not match..Try Again! \n");
                StartGame();
            }
        }

        public void StopGame()
        {
            Console.WriteLine("The Game will be Discontinued in few seconds");

        }
    }
    class Game
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("This game has two levels");
            Console.WriteLine("In each level you have to type a string");

            Console.WriteLine("You have 25 seconds to complete the game\n");
            GameEg obj = new GameEg();
            {
                Thread t = new Thread(new ThreadStart(obj.StopGame));
                t.Start();//Starting the new thread
                Thread.Sleep(25000); //Making the Main thread sleep for 25 Seconds /
                 try
                    {
                        t.Abort();
                        Console.WriteLine("\n\nSorry You lose! The Time is Over!");
                    }//Killing the new thread
                    catch (ThreadAbortException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                //Thread t = new Thread(new ThreadStart(obj.StartGame));
                //t.Start();//Starting the new thread
                //Thread.Sleep(25000); /Making the Main thread sleep for 25 Seconds/
                //try
                //{
                //    t.Abort();
                //    Console.WriteLine("\n\nSorry You lose! The Time is Over!");
                //}//Killing the new thread
                //catch (ThreadAbortException e)
                //{
                //    Console.WriteLine(e.Message);
                //}
            }
            Console.ReadLine();
        }
    }
}