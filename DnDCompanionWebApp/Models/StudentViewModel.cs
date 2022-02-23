using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDCompanionWebApp.Models;
namespace DnDCompanionWebApp.Models
{
    public class StudentViewModel : StudentModel
    {

        public int AccParam { get; set; }
        public StudentViewModel(string firstName, string lastName, string grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;

        }
        StudentViewModel stu1 = new StudentViewModel("George", "Johnson","A");
        StudentViewModel stu2 = new StudentViewModel("John", "Johnson", "A");
        StudentViewModel stu3 = new StudentViewModel("Sam", "Johnson", "A");
        StudentViewModel stu4 = new StudentViewModel("Ken", "Johnson", "A");








    }
}
