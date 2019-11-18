using System;
using System.Collections.Generic;

namespace StudentExercises
{

    public class Student
    {
        public Student(string first, string last, string slack){
            _firstName = first;
            _lastName = last;
            _slackHandle = slack;
        }

        //public
        public string _firstName {get;}
        public string _lastName {get;}
        public string _slackHandle {get;}
        public Cohort CurrentCohort {get; set;}
        public List<Exercise> Exercises = new List<Exercise>();
    }
}