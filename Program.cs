﻿using System;
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

            List<string> classGrades = new List<string>()
        {
            "80, 100, 92, 89, 65",
            "93, 81, 78, 84, 69",
            "73, 88, 83, 99, 64",
            "98, 100, 66, 74, 55"
        };

            string input = "Terrill";


            Words words = new Words();
            Names names = new Names();
            Grades grades = new Grades();
            Letters letters = new Letters();

            words.GetWordsWithTh();
            names.RemoveDuplicates();
            grades.GetAverage(classGrades);
            letters.ReturnLettersAlphabeticallyOrdered(input);
        }

       

        


    }
}