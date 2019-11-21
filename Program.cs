using System;
using System.Collections.Generic;
using System.Linq;

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
            Student NateVogal = new Student("Nate", "Vogal", "nate-vogal");

            //Instructors
            Instructor BrendaLong = new Instructor("Brenda", "Long", "brenda-long", "UI/UX");
            Instructor MoSilvera = new Instructor("Mo", "Silvera", "mo-silvera", "Javascript");
            Instructor AdamSheaffer = new Instructor("Adam", "Sheaffer", "adam-sheaffer", "C#");

            //Assigning Students to Cohorts
            cohort1.StudentList.Add(JamesMcClarty);
            JamesMcClarty.CurrentCohort = cohort1;
            cohort2.StudentList.Add(StephanSenft);
            StephanSenft.CurrentCohort = cohort2;
            cohort3.StudentList.Add(ArynWeatherly);
            cohort3.StudentList.Add(ShirishShrestha);
            ArynWeatherly.CurrentCohort = cohort3;
            ShirishShrestha.CurrentCohort = cohort3;
            cohort1.StudentList.Add(NateVogal);
            NateVogal.CurrentCohort = cohort1;

            //Assigning Teachers to Cohorts
            cohort1.InstructorList.Add(BrendaLong);
            BrendaLong.CurrentCohort = cohort1;
            cohort2.InstructorList.Add(MoSilvera);
            MoSilvera.CurrentCohort = cohort2;
            cohort3.InstructorList.Add(AdamSheaffer);
            AdamSheaffer.CurrentCohort = cohort3;

            //Assign Assignments to Students
            BrendaLong.AssignExercise(JamesMcClarty, exercise2);
            MoSilvera.AssignExercise(StephanSenft, exercise4);
            AdamSheaffer.AssignExercise(ArynWeatherly, exercise1);
            AdamSheaffer.AssignExercise(ShirishShrestha, exercise3);
            AdamSheaffer.AssignExercise(ArynWeatherly, exercise3);
            AdamSheaffer.AssignExercise(ShirishShrestha, exercise1);
            AdamSheaffer.AssignExercise(ArynWeatherly, exercise2);

            // Challenge
            List<Student> students = new List<Student>();
            students.Add(JamesMcClarty);
            students.Add(StephanSenft);
            students.Add(ArynWeatherly);
            students.Add(ShirishShrestha);
            students.Add(NateVogal);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(exercise1);
            exercises.Add(exercise2);
            exercises.Add(exercise3);
            exercises.Add(exercise4);

            List<Instructor> instructors = new List<Instructor>() { BrendaLong, MoSilvera, AdamSheaffer };
            List<Cohort> cohorts = new List<Cohort>() { cohort1, cohort2, cohort3 };

            foreach (Student student in students)
            {
                Console.WriteLine($"Student: {student._firstName} {student._lastName}");
                Console.WriteLine("Exercises:");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"Program: {exercise._name} Language: {exercise._language}");
                }
            }

            List<Exercise> javaExercises = exercises.Where(e => e._language.Contains("Javascript")).ToList<Exercise>();

            foreach (Exercise exercise in javaExercises)
            {
                Console.WriteLine($"Java Program: {exercise._name} Language: {exercise._language}");
            }

            List<Student> studentsInCohort = students.Where(e => e.CurrentCohort._name.Contains("34")).ToList<Student>();

            foreach (Student student in studentsInCohort)
            {
                Console.WriteLine($"Student: {student._firstName} {student._lastName} Cohort: {student.CurrentCohort._name}");
            }

            List<Instructor> instructorsInCohort = instructors.Where(e => e.CurrentCohort._name.Contains("32")).ToList<Instructor>();

            foreach (Instructor instructor in instructorsInCohort)
            {
                Console.WriteLine($"Instructor: {instructor._firstName} {instructor._lastName} Cohort: {instructor.CurrentCohort._name}");
            }

            List<Student> studentsSorted = students.OrderBy(e => e._lastName).ToList<Student>();

            foreach (Student student in studentsSorted)
            {
                Console.WriteLine($"{student._firstName} {student._lastName}");
            }

            List<Student> studentsWithNoExercises = students.Where(e => e.Exercises.Count == 0).ToList<Student>();

            foreach (Student student in studentsWithNoExercises)
            {
                Console.WriteLine($"{student._firstName} {student._lastName} has no assignments.");
            }

            List<Student> studentsWithMostExercises = students.OrderByDescending(student => student.Exercises.Count).ToList<Student>();
            Console.WriteLine($"{studentsWithMostExercises.First()._firstName} {studentsWithMostExercises.First()._lastName} has {studentsWithMostExercises.First().Exercises.Count} assignments.");

            var cohortStudentCount = cohorts.GroupBy(
                p => p._name,
                p => p.StudentList.Count,
                (key, g) => new { cohortName = key, student = g });

            foreach (var cohort in cohortStudentCount)
            {
                Console.WriteLine($"{cohort.cohortName}: {cohort.student.First()} students.");
            }
        }
    }
}