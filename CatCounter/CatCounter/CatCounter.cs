using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CatCounter {
    public class CountAllCats {
        
        public int CountCats(string sentence) {
            int count = 0;
            string pattern = "(?i)cats?";
            foreach (Match m in Regex.Matches(sentence, pattern)) {
                count++;
            }
            return count;
        }

        //public int CountCats(string sentence) {
        //    string[] words = sentence.ToLower().Split(' ');
        //    int count = 0;
        //    foreach (var word in words) {
        //        if(word == "cat") {
        //            return count++;
        //        }
        //    }
        //    Console.WriteLine("'Cat' appears {0} times in the sentence.", count);
        //}
        
    }
}
