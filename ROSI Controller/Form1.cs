using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Firefox;

namespace ROSI_Controller
{
    public partial class Form1 : Form
    {
        protected string studentNumber;
        protected string pin;

        SeleniumOperator op;
        FirefoxDriver driver;

        public Form1()
        {
            InitializeComponent();
            driver = new FirefoxDriver();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sNumText.Text.Length > 1 && pinText.Text.Length > 1)
            {
                studentNumber = sNumText.Text;
                pin = pinText.Text;
                op = new SeleniumOperator(studentNumber, pin);
                bool loginSuccess = op.login(driver);
                if (loginSuccess)
                    general.SelectTab("operation");
                else
                {
                    if (driver.PageSource.Contains("Server not found"))
                        MessageBox.Show("Please check your internet connection");
                    else
                        MessageBox.Show("Please enter the correct login information");
                }
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
                bool success = op.addSingleCourse(c, driver);
                if (success)
                    MessageBox.Show((c.getFullCourseCode() + " has been successfully added!"));
                else
                    MessageBox.Show("An error occrued while adding the course");
            }
        }

        private void errorHandler(string page)
        {
        }
    }
}