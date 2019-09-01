using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqproblems
{
    class Words
    {
        public static List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        
        public List<string> GetWordsWithTh()
        {
            string th = "th";
            var findWords = words.Where(w => w.Contains(th)).ToList();
            return findWords;
        }  
    }
}
