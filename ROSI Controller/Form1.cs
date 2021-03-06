﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace ROSI_Controller
{
    public partial class Form1 : Form
    {
        protected string studentNumber;
        protected string pin;

        SeleniumOperator op;
        FirefoxDriver driver;
        List<Tuple<Label, TextBox>> cc = new List<Tuple<Label, TextBox>>();
        List<Tuple<Label, TextBox>> sc = new List<Tuple<Label, TextBox>>();
        List<Tuple<Label, TextBox>> ls = new List<Tuple<Label, TextBox>>();

        List<Tuple<int, int>> columnOneLabel = new List<Tuple<int, int>>();
        List<Tuple<int, int>> columnOneText = new List<Tuple<int, int>>();
        List<Tuple<int, int>> columnTwoLabel = new List<Tuple<int, int>>();
        List<Tuple<int, int>> columnTwoText = new List<Tuple<int, int>>();
        
        int courseCount = 0;
        int newRowSpacing = 100;
        int rowCount = 0;


        public Form1()
        {
            InitializeComponent();
            columnOneLabel.Add(Tuple.Create(22, 15));
            columnOneLabel.Add(Tuple.Create(22, 42));
            columnOneLabel.Add(Tuple.Create(11, 69));
            columnOneText.Add(Tuple.Create(99, 15));
            columnOneText.Add(Tuple.Create(99, 42));
            columnOneText.Add(Tuple.Create(99, 69));

            columnTwoLabel.Add(Tuple.Create(239, 15));
            columnTwoLabel.Add(Tuple.Create(239, 42));
            columnTwoLabel.Add(Tuple.Create(228, 69));
            columnTwoText.Add(Tuple.Create(316, 15));
            columnTwoText.Add(Tuple.Create(316, 42));
            columnTwoText.Add(Tuple.Create(316, 69));

            driver = new FirefoxDriver();
        }

        private void loginButton_Click(object sender, EventArgs e)
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
                bool success = false;
                if (checkBox1.Checked)
                {
                    string courseCode = singleCourseCodeTextbox.Text.ToUpper();
                    string sectionCode = singleSectionCodeTextbox.Text.ToUpper();
                    string lectureSection = singleLectureSectionBox.Text;
                    Course c = new Course(courseCode, sectionCode, lectureSection);
                    while (!success)
                    {
                        success = op.addSingleCourse(c, driver, true);
                        Thread.Sleep(TimeSpan.FromSeconds(30));  // 30 second pause
                    }

                    if (success)
                        MessageBox.Show((c.getFullCourseCode() + " has been successfully added!"));
                }
                else
                {
                    string courseCode = singleCourseCodeTextbox.Text.ToUpper();
                    string sectionCode = singleSectionCodeTextbox.Text.ToUpper();
                    string lectureSection = singleLectureSectionBox.Text;
                    Course c = new Course(courseCode, sectionCode, lectureSection);
                    success = op.addSingleCourse(c, driver, false);
                    if (success)
                        MessageBox.Show((c.getFullCourseCode() + " has been successfully added!"));
                    else
                        MessageBox.Show("An error occrued while adding the course");
                }
            }
            else
                MessageBox.Show("Please complete the course information form");
        }

        /// <summary>
        /// Dynamically add course information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, EventArgs e)
        {
            Label l1 = new Label();
            l1.Text = "Course Code:";
            Label l2 = new Label();
            l2.Text = "Section Code:";
            Label l3 = new Label();
            l3.Text = "Lecture Section:";

            TextBox b1 = new TextBox();
            TextBox b2 = new TextBox();
            TextBox b3 = new TextBox();

            cc.Add(Tuple.Create(l1, b1));
            sc.Add(Tuple.Create(l2, b2));
            ls.Add(Tuple.Create(l3, b3));
            
            if (courseCount % 2 == 0)  // column one
            {
                // check if new row
                l1.Location = new Point(columnOneLabel[0].Item1, columnOneLabel[0].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(l1);
                l1.BringToFront();
                l2.Location = new Point(columnOneLabel[1].Item1, columnOneLabel[1].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(l2);
                l2.BringToFront();
                l3.Location = new Point(columnOneLabel[2].Item1, columnOneLabel[2].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(l3);
                l3.BringToFront();

                b1.Location = new Point(columnOneText[0].Item1, columnOneText[0].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(b1);
                b1.BringToFront();
                b2.Location = new Point(columnOneText[1].Item1, columnOneText[1].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(b2);
                b2.BringToFront();
                b3.Location = new Point(columnOneText[2].Item1, columnOneText[2].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(b3);
                b3.BringToFront();
            }
            else  // column two
            {
                l1.Location = new Point(columnTwoLabel[0].Item1, columnTwoLabel[0].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(l1);
                l1.BringToFront();
                l2.Location = new Point(columnTwoLabel[1].Item1, columnTwoLabel[1].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(l2);
                l2.BringToFront();
                l3.Location = new Point(columnTwoLabel[2].Item1, columnTwoLabel[2].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(l3);
                l3.BringToFront();

                b1.Location = new Point(columnTwoText[0].Item1, columnTwoText[0].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(b1);
                b1.BringToFront();
                b2.Location = new Point(columnTwoText[1].Item1, columnTwoText[1].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(b2);
                b2.BringToFront();
                b3.Location = new Point(columnTwoText[2].Item1, columnTwoText[2].Item2 + rowCount * newRowSpacing);
                this.panel1.Controls.Add(b3);
                b3.BringToFront();
            }

            ++courseCount;
            if (courseCount % 2 == 0)
                ++rowCount;
        }

        private void multiConfirm_Click(object sender, EventArgs e)
        {
            List<string> noneSuccess = new List<string>();
            for (int i = 0; i < courseCount; ++i)
            {
                if (cc[i].Item2.TextLength > 0 && sc[i].Item2.TextLength > 0 && ls[i].Item2.TextLength > 0)
                {
                    string courseCode = cc[i].Item2.Text.ToUpper();
                    string sectionCode = sc[i].Item2.Text.ToUpper();
                    string lectureSection = ls[i].Item2.Text.ToUpper(); ;
                    Course course = new Course(courseCode, sectionCode, lectureSection);
                    bool success = op.addSingleCourse(course, driver, false);
                    if (!success)
                        noneSuccess.Add(course.getFullCourseCode());
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }

            if (noneSuccess.Count > 0)
            {
                string errormsg = "Due to some errors the following course(s) are not added: \r\n";
                for (int i = 0; i < noneSuccess.Count; ++i)
                {
                    errormsg += (noneSuccess[i] + "\r\n");
                }
                MessageBox.Show(errormsg);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("You should only use this function when the waitlist is dropped \r\n and make sure your schedule is not at maximum course load.");
            }
        }

        private void errorHandler(string page)
        {
        }
    }
}