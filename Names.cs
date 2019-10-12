using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqproblems
{
    class Names
    {
        public static List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

        public List<string> RemoveDuplicates()
        {
            string isMike = "Mike";
            var findMike = names.RemoveAll(n => n == isMike);
            var newListNoMikes = names.ToList();
            return newListNoMikes;
        }

    }
}
