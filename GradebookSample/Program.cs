using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookSample
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook("Jenny");

            myGradeBook.DisplayMessage();

            myGradeBook.InputGrades();

            myGradeBook.DisplayGradeReport();

            Console.ReadLine();
        }
    }
}
