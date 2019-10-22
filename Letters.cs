using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqproblems
{
    class Letters
    {
        public void ReturnLettersAlphabeticallyOrdered(string userInput)
        {
            StringBuilder sb = new StringBuilder();
            var input = userInput.ToLower();
            var newString = input.GroupBy(x => x, (key, duplicates)
                                            => new { Letter = key, Duplicates = duplicates.Count() })
                                 .OrderBy(x => x.Letter);

            foreach (var item in newString)
            {
                sb.Append($"{item.Letter}{item.Duplicates}");
            }
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

