using System;
using System.Collections.Generic;

namespace StudentExercises{

    public class Instructor{

        public Instructor(string first, string last, string slack, string specialty){
            _firstName = first;
            _lastName = last;
            _slackHandle = slack;
            _specialty = specialty;
        }
        
        //public
        string _firstName {get;}
        private string _lastName {get;}
        private string _slackHandle {get;}
        private string _specialty {get;}
        public Cohort CurrentCohort {get; set;}
        public void AssignExercise(Student student, Exercise exercise){
            student.Exercises.Add(exercise);
        }
    }
}