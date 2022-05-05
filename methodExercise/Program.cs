using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to lala land!");
            Console.WriteLine("Here at lala land you and I are a team. Together we will make a story!");
            Console.WriteLine("Before we get started, may I ask your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {name}! My name is Lala Bot!");
            Console.WriteLine("Now I promise to get to our story soon, but first, I have a five important questions for you...");
            Console.WriteLine("1. What is the BEST age to be?");
            var age = Console.ReadLine();
            Console.WriteLine("2. What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("3. What is one food you couldn't live without?");
            var food = Console.ReadLine();
            Console.WriteLine("4. If you were stranded on an island and could only have one item, what would you pick?");
            var item = Console.ReadLine();
            Console.WriteLine("5. What is the worst song you've ever heard?");
            var song = Console.ReadLine();
           

            Console.WriteLine($"Thanks for answering all those questions, {name}! It was great to get to know you!"); 


            Console.WriteLine(" While you were answering those, I was hard at work creating our story. Are you ready to hear it? I hope so! Here we go! ");
            Console.WriteLine("BREAKING NEWS!!!");
            Console.WriteLine($"After {age} years, royal family member {name} has been found! \r\n " +
                $"As the community began to lose hope of {name}'s survival," +
                $"one soldier refused to give up. \r\n " +
                $"This soldier began playing {song} on loud speakers, hoping that if {name} heard it they would scream in horror. \r\n" +
                $"This plan proved successful as {name} was located screaming in the woods. \r\n " +
                $"At ths time, the royal family is refusing to make a statement. " +
                $"However, inside sources report that {name} was raised by {animal} and survived soley on {food}. \r\n " +
                $"Now that {name} is home, they are being introduced to luxary items, starting with {item}'s.");
         



            


           

            
        }
    }
}
