using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqproblems
{
    class Grades
    {
        List<string> classGrades = new List<string>()
        {
            "80, 100, 92, 89, 65",
            "93, 81, 78, 84, 69",
            "73, 88, 83, 99, 64",
            "98, 100, 66, 74, 55"
        };
        public double GetAverage(List<string> gradeList)
        {
            List<double> newList = new List<double>();
            double averageBaseline = 0.00;
            for (int i = 0; i < gradeList.Count; i++)
            {
                List<double> numValue = gradeList[i].Split(',').Select(double.Parse).ToList();
                newList = numValue.OrderByDescending(g => g).Take(numValue.Count() - 1).ToList();
                double gradeAvg = newList.Average();

                averageBaseline += gradeAvg;
            }
            double listOfAverages = averageBaseline / gradeList.Count;
            Console.WriteLine(listOfAverages);
            Console.ReadLine();
            return listOfAverages;
        }
    }
}