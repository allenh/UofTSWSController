using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSI_Controller
{
    class Course
    {
        private string courseCode;
        private string sectionCode;
        private string lectureSection;
        public Course(string courseCode, string sectionCode, string lectureSection)
        {
            this.courseCode = courseCode;
            this.sectionCode = sectionCode;
            this.lectureSection = lectureSection;
        }

        public string getCourseCode()
        {
            return this.courseCode;
        }
        
        public string getSectionCode()
        {
            return this.sectionCode;
        }
        
        public string getLectureSection()
        {
            return this.lectureSection;
        }

        public string getFullCourseCode()
        {
            return (this.courseCode + this.sectionCode);
        }

    }
}