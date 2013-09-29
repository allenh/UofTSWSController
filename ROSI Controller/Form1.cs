using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROSI_Controller
{
    public partial class Form1 : Form
    {
        protected string studentNumber;
        protected string pin;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sNumText.Text.Length > 1 && pinText.Text.Length > 1)
            {
                studentNumber = sNumText.Text;
                pin = pinText.Text;
                
                general.SelectTab("operation");
            }
            else
                MessageBox.Show("Please complete the form in order to continue!");
        }

        private void singleCourseButton_Click(object sender, EventArgs e)
        {
            if (singleCourseCodeTextbox.Text.Length > 0 && singleSectionCodeTextbox.Text.Length > 0)
            {
                
                string courseCode = singleCourseCodeTextbox.Text.ToUpper();
                string sectionCode = singleSectionCodeTextbox.Text.ToUpper();
                string lectureSection = singleLectureSectionBox.Text;
                Course c = new Course(courseCode, sectionCode, lectureSection);
                SeleniumOperator sop = new SeleniumOperator(studentNumber, pin);
                bool success = sop.addSingleCourse(c);
                if (success)
                    MessageBox.Show("{0} has been successfully added", c.getFullCourseCode());
                else
                    MessageBox.Show("An error occrued while adding the course");
            }
        }
    }
}