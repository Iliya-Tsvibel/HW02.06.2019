using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HWThread
{
    class Program
    {

        private static void ThreadWork()
        {
            for (int i = 5; i > 0; i--)
            {


                Thread.Sleep(1000);
                Console.WriteLine($"{i}");
                Console.WriteLine();

            }


        }
       

        static void Main(string[] args)
        {

            int tryAgain = 1;
            Random r = new Random();
            {

                while (tryAgain == 1)
                {
                    Console.WriteLine("See at those two randomly chosen numbers:");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    int number1 = r.Next(0, 9);
                    int number2 = r.Next(0, 9);
                    Console.WriteLine($"***{number1}***");
                    Thread.Sleep(1000);
                    Console.WriteLine($"***{number2}***");
                    int result = (number1 * number2);
                    Console.WriteLine();
                    Console.WriteLine("Write your answer below");

                    Thread t = new Thread(ThreadWork);
                    t.Start();
                    t.IsBackground = true;
                   
                    

                                    
                      Console.WriteLine("You have 5 seconds to calculate the multiplication of these two numbers");


                        int answer = Convert.ToInt32(Console.ReadLine());
                       
                   

                        if (t.ThreadState != ThreadState.Stopped && answer == result)
                        {
                            t.Abort();
                            Console.WriteLine("You are Great!");
                            Console.WriteLine("If you wint to play again, press 1, another press any kay except 1");

                            tryAgain = Convert.ToInt32(Console.ReadLine());
                            //ClearScreen();
                        }

                        else
                            Console.WriteLine("Wrong calculation or time is pass");
                            Console.WriteLine("If you wint to play again, press 1, another press any NUMBER except 1");

                        tryAgain = Convert.ToInt32(Console.ReadLine());
                        //ClearScreen();

                        //t.Join();
                        //Console.WriteLine("opa");
                    

                }
                    //void ClearScreen()
                    //{
                    //   Console.Clear();

                    //}



            }
           
        }
        
                
    }  
}
