using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "";  // it holds the user input
            string filename = "dict.txt";
            List<string> wordList = new List<string>();

            WordChecker Word = new WordChecker();

            Word.Reding_file(filename);

            Console.Write ("Enter a word:  ");
            input = Console.ReadLine();     //read line

            input = input.ToLower();

            while (input != "-q")

            {

                if (Word.SearchWord(input))
                {
                    Console.WriteLine("OK");
                }
                else {

                    wordList = Word.Word_Space(input); 
                   

                }

                Display(wordList);
                                     
                Console.Write("Enter a word:  ");
                input = Console.ReadLine();
                input = input.ToLower();
            }


            Console.WriteLine("Aplication ends");
            Console.ReadKey();
        }


        public static void  Display(List <string> list) {

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }



    }
}
