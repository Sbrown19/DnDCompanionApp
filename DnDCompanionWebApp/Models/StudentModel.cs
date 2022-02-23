using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDCompanionWebApp.Models
{
    public class StudentModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public StudentModel()
        {

        }

        public StudentModel(string firstName)
        {
            FirstName = FirstName;
        }

        public StudentModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

        public StudentModel(string firstName, string lastName, string grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;

        }


    }
}
