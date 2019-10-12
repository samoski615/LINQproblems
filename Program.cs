using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqproblems
{
    class Program
    {

        static void Main(string[] args)
        {
            Words words = new Words();
            Names names = new Names();
            Grades grades = new Grades();

            words.GetWordsWithTh();
            names.RemoveDuplicates();
            grades.GetAverage();
        }

       

        


    }
}