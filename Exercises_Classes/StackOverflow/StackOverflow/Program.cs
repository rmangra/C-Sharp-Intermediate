using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("This is a test post", "The quick brown fox jumped over the lazy dog", 2);

            Console.WriteLine("Title: " + post.Title);
            Console.WriteLine("Description: " + post.Description);
            Console.WriteLine("TimeStamp: " + post.TimeStamp);
            Console.WriteLine("Up-Vote: " + post.up_vote());
            Console.WriteLine("Down-Vote: " + post.down_vote());
            Console.ReadLine();
        }
    }
}
