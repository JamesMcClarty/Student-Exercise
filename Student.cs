using System;
using System.Collections.Generic;

namespace StudentExercises
{

    public class Student: NSSPerson
    {
        public Student(string first, string last, string slack){
            _firstName = first;
            _lastName = last;
            _slackHandle = slack;
        }

        //public
        public List<Exercise> Exercises = new List<Exercise>();
    }
}