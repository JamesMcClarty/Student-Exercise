using System;
using System.Collections.Generic;

namespace StudentExercises{

    public class Instructor:NSSPerson{

        public Instructor(string first, string last, string slack, string specialty){
            _firstName = first;
            _lastName = last;
            _slackHandle = slack;
            _specialty = specialty;
        }
        
        public string _specialty {get;}
        public void AssignExercise(Student student, Exercise exercise){
            student.Exercises.Add(exercise);
        }
    }
}