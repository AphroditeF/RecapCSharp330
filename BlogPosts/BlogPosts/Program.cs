using BlogPosts;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Denis Panjuta", "https://images.com/shoes", true);


            Console.WriteLine(imagePost1.ToString());
            
            Console.ReadLine();
        }


    }
}