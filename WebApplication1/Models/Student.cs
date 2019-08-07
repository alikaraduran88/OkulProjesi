using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public int Student_Number { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public DateTime Student_Birtdate { get; set; }
        public int Student_TC_No { get; set; }
    }
}