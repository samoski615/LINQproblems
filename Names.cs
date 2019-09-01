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

        public void RemoveDuplicates(char mike)
        {
            char m = mike;
            var removeMike = names.Where(n => n.Distinct<char>(mike));
        }

    }
}
