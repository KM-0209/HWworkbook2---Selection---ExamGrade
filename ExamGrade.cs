using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Prompts the user to enter a students marks and then works out their grade, and the number of marks they are from the next grade 
class Program
{
    // Works out students grade and the number of marks they are from the next grade
    static string ExamGrade(int marks, out int next_grade_marks)
    {
        // Selection that outputs different statements based off of students grade
        next_grade_marks = 0;
        if (marks >= 80)
            return "9";
        else if (marks >= 67)
        {
            next_grade_marks = 80 - marks;
            return "8";
        }
        else if (marks >= 54)
        {
            next_grade_marks = 67 - marks;
            return "7";
        }
        else if (marks >= 41)
        {
            next_grade_marks = 54 - marks;
            return "6";
        }
        else if (marks >= 31)
        {
            next_grade_marks = 41 - marks;
            return "5";
        }
        else if (marks >= 22)
        {
            next_grade_marks = 31 - marks;
            return "4";
        }
        else if (marks >= 13)
        {
            next_grade_marks = 22 - marks;
            return "3";
        }
        else if (marks >= 4)
        {
            next_grade_marks = 13 - marks;
            return "2";
        }
        else if (marks >= 2)
        {
            next_grade_marks = 4 - marks;
            return "1";
        }
        else if (marks >= 0)
        {
            next_grade_marks = 2 - marks;
            return "U";
        }

        return "U";
    }
    
    
    // The main entry point of the program
    static void Main(string[] args)
    {
        int marks;
        int next_grade_marks;

        next_grade_marks = 0;

        // Allows user to input their marks to find their grade
        Console.Write("Enter your marks (0-100): ");
        while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
        {
            Console.Write("Invalid input. Please enter a valid mark (0-100): ");
        }

        string grade = ExamGrade(marks, out next_grade_marks);
        
        // Sorts final output statement based of the stidents grade
        if (grade == "9")
        {
            Console.WriteLine($"A mark of {marks} is grade 9. That is the top grade!");
        }
        else
        {
            Console.WriteLine($"A mark of {marks} is grade {grade}. You need {next_grade_marks} more marks to reach the next grade.");
        }
    
    }
}
