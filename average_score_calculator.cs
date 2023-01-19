using System;
using static System.Console;

//Write a program named YourTest that declares five variables to hold scores (integer numbers) for five tests you have taken and accepts these test scores from a user. Display the average of the test scores to two decimal places.

namespace PartA
{
    class YourTest
    {
        static void Main(string[] args)
        {
            //Declare values and test scores I have taken
            int test1 = 67, test2 = 90, test3 = 100, test4 = 45, test5 = 85;
            double average;
            //Display my average test score
            average = (test1 + test2 + test3 + test4 + test5) / 5.00;
            WriteLine($"\nMy average test score is: {average:0.00}\n");
            //Accept five test scores from a user
            Write("Input Your Test1 score: ");
            test1 = Convert.ToInt32(ReadLine());
            Write("Input Your Test2 score: ");
            test2 = Convert.ToInt32(ReadLine());
            Write("Input Your Test3 score: ");
            test3 = Convert.ToInt32(ReadLine());
            Write("Input Your Test4 score: ");
            test4 = Convert.ToInt32(ReadLine());
            Write("Input Your Test5 score: ");
            test5 = Convert.ToInt32(ReadLine());
            //Calculate user's average score
            average =  (test1 + test2 + test3 + test4 + test5) / 5.00;
            //Display user's average score with two decimal places
            WriteLine($"\nYour average test score is: \n {average:0.00}");

            ReadKey();
        }
    }
}
