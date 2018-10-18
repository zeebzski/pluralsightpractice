using System;
using System.Collections.Generic;
using System.Text;

namespace Grades.Core
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowawayGradebook::ComputeStatistics");

            float lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);

            return base.ComputeStatistics();
        }
    }
}
