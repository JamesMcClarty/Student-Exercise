using System;
using System.Collections.Generic;

namespace StudentExercises{

    public class Cohort{

     public Cohort(string name){
            _name = name;
        }

        private string _name;

        public List<Student> StudentList = new List<Student>();
        public List<Instructor> InstructorList = new List<Instructor>();
    }
}