using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Lesson
    {
        public string LessonID { get; set; }
        public string LessonName { get; set; }
        public string Aciklama { get; set; }
        public int Teacher_SicilNo { get; set; }
    }
}