using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userName = new string[3];
            userName[0] = "user-1";
            userName[1] = "second-2";
            userName[2] = "third-3";

            string[] passWord = new string[3];
            passWord[0] = "pass#1";
            passWord[1] = "pass#2";
            passWord[2] = "pass#3";

            
            for (int index = 0; index < 3; index++)
            {
                if (index == 2)
                {
                    index = 0;
                    Console.WriteLine(userName[index]);
                    Console.WriteLine(passWord[index]);
                }  
                else
                {
                    Console.WriteLine(userName[index]);
                    Console.WriteLine(passWord[index]);
                }
            }
            

        }
    }
}
