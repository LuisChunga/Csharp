using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    // use to read file
using System.Collections;

namespace ConsoleApplication2
{
    class WordChecker
    {
        Hashtable dictionary = new Hashtable();
        List<string> listWord = new List<string>();

        public void Reding_file(string filename) {

            string word = "";
            // opens a external file
            StreamReader inFile = new StreamReader(@filename);
       
            while((word = inFile.ReadLine()) != null)
                dictionary.Add(word, word);
            

            inFile.Close();
        }
        
           
        // this function return true if the word is in the list 
        public bool SearchWord (string words) {

            return dictionary.ContainsValue(words);           
              
        }


        public List<string> Word_Space(string word) {

            string s1 = "";
            string s2 = "";

            for (int i = 1; i < word.Length; i++)
            {
                s1 = word.Substring(0, i);
                s2 = word.Substring(i, word.Length-i);

                if (SearchWord(s1) && SearchWord(s2))
                    listWord.Add(s1 + " " +s2);
                   
                

            }

            return listWord;
        }




    }
}
