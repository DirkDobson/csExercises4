using System;
using System.IO;

namespace csExercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"/Users/dirkvancouver/foobar/bar.txt";

            Console.WriteLine(File.Exists(path) ? "It exists." : "It does not exist.");
            var file = File.ReadAllText(path);
            var words = file.Split(" ");
            System.Console.WriteLine(words.Length);
            
            var total = words[0];
            foreach(var word in words)
            {
                if(word.Length > total.Length)
                {
                    total = word;
                }
            }
            System.Console.WriteLine(total);
        }
    }
}
