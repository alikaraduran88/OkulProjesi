using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Yoklama
    {
        public string LessonID { get; set; }
        public int Student_Number { get; set; }

        public DateTime Date { get; set; }

        public string Geldimi { get; set; }

        public int YoklamaID { get; set; }

    }
}