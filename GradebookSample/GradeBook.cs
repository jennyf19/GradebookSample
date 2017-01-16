using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookSample
{
    class GradeBook
    {
        private int total; //sum of grades
        private int gradeCounter; //number of grades entered
        private int aCount; //count of A grades
        private int bCount;
        private int cCount;
        private int dCount;
        private int fCount;

        //automatic property CourseName
        public string CourseName { get; set; }

        //constructor initializes automatic proerpty CourseName;
        //int instance variables are initialized to 0 by default
        public GradeBook(string name)
        {
            CourseName = name;//set CourseName to name
        }//end constructor

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to Grade Book!");
        }

        public void InputGrades()
        {
            int grade; //grade entered by user
            string input; //text entered by user

            Console.WriteLine("{0}\n{1}",
                "Enter the integer grades in the range 0-100.",
                "Type <Ctrl> z and press Enter to terminate input: ");

            input = Console.ReadLine();

            //loop until user enters end-of-file indicator
            while (input != null)
            {
                grade = Convert.ToInt32(input);
                total += grade; //add grade to total
                ++gradeCounter; //increment number of grades

                //call method to increment appropriate counter
                IncrementLetterGradeCounter(grade);

                input = Console.ReadLine();
            }
        }

        private void IncrementLetterGradeCounter(int grade)
        {
            //determine which grade was entered
            switch (grade / 10)
            {
                case 9:
                case 10:
                    ++aCount;
                    break;
                case 8:
                    ++bCount;
                    break;
                case 7:
                    ++cCount;
                    break;
                case 6:
                    ++dCount;
                    break;
                default:
                    ++fCount;
                    break;
            }
        }

        public void DisplayGradeReport()
        {
            Console.WriteLine("\nGrade Report:");

            if (gradeCounter != 0)
            {
                //calculate average of all grades entered
                double average = (double)total / gradeCounter;

                Console.WriteLine("Total of the {0} grades entered is {1}", gradeCounter, total);
                Console.WriteLine("{0}A: {1}\nB: {2}\nC: {3}\nD: {4}\nF: {5}",
                    "Number of students who receieved each grade:\n",
                    aCount,
                    bCount,
                    cCount,
                    dCount,
                    fCount);
            }
            else
            {
                Console.WriteLine("No grades were entered");
            }
        }
    }
}
