using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises
            Exercise exercise1 = new Exercise("Make a heist", "C#");
            Exercise exercise2 = new Exercise("Make a bunch of loops", "Javascript");
            Exercise exercise3 = new Exercise("Make a high five simulator", "C#");
            Exercise exercise4 = new Exercise("Create a relational database", "SQL");

            //Cohorts
            Cohort cohort1 = new Cohort("Cohort 32");
            Cohort cohort2 = new Cohort("Cohort 33");
            Cohort cohort3 = new Cohort("Cohort 34");

            //Students
            Student JamesMcClarty = new Student("James", "McClarty", "james-mcclarty");
            Student StephanSenft = new Student("Stephan", "Senft", "stephan-senft");
            Student ArynWeatherly = new Student("Aryn", "Weatherly", "aryn-weatherly");
            Student ShirishShrestha = new Student("Shirish", "Shrestha", "shirish-shrestha");

            //Instructors
            Instructor BrendaLong = new Instructor("Brenda", "Long", "brenda-long", "UI/UX");
            Instructor MoSilvera = new Instructor("Mo", "Silvera", "mo-silvera", "SQL");
            Instructor AdamSheaffer = new Instructor("Adam", "Sheaffer", "adam-sheaffer", "C#");

            //Assigning Students to Cohorts
            cohort1.StudentList.Add(JamesMcClarty);
            cohort2.StudentList.Add(StephanSenft);
            cohort3.StudentList.Add(ArynWeatherly);
            cohort3.StudentList.Add(ShirishShrestha);

            //Assigning Teachers to Cohorts
            cohort1.InstructorList.Add(BrendaLong);
            cohort2.InstructorList.Add(MoSilvera);
            cohort3.InstructorList.Add(AdamSheaffer);

            //Assign Assignments to Students
            BrendaLong.AssignExercise(JamesMcClarty, exercise2);
            MoSilvera.AssignExercise(StephanSenft, exercise4);
            AdamSheaffer.AssignExercise(ArynWeatherly, exercise1);
            AdamSheaffer.AssignExercise(ShirishShrestha, exercise3);
            AdamSheaffer.AssignExercise(ArynWeatherly, exercise3);
            AdamSheaffer.AssignExercise(ShirishShrestha, exercise1);

            // Challenge
            List<Student> students = new List<Student>();
            students.Add(JamesMcClarty);
            students.Add(StephanSenft);
            students.Add(ArynWeatherly);
            students.Add(ShirishShrestha);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(exercise1);
            exercises.Add(exercise2);
            exercises.Add(exercise3);
            exercises.Add(exercise4);

            foreach (Student student in students)
            {
                Console.WriteLine($"Student: {student._firstName} {student._lastName}");
                Console.WriteLine("Exercises:");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"Program: {exercise._name} Language: {exercise._language}");
                }
            }
        }
    }
}