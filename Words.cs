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

        public void GetWordsWithTh()
        {
                   var getQuery =
                   from th in words
                   where Char.IsSymbol(th)
                   select th;
        }


        public static List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

        public void RemoveDuplicates()
        {
            var matchWord =
                from word in names
                where word.Any<>
                
        }



       






    }
}
