﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace ROSI_Controller
{
    class SeleniumOperator
    {
        private string studentNumber;
        private string pin;
        private readonly string sws = "https://sws.rosi.utoronto.ca";
        private readonly string enrolmentPage = "https://sws.rosi.utoronto.ca/sws/reg/main.do?main.dispatch";

        public SeleniumOperator(string studentNumber, string pin)
        {
            this.studentNumber = studentNumber;
            this.pin = pin;
        }

        /// <summary>
        /// Return true iff the course specified is added successfully;
        /// return false otherwise.
        /// </summary>
        /// <param name="c">Course course</param>
        /// <returns></returns>
        public bool addSingleCourse(Course course)
        {
            try
            {
                FirefoxDriver driver = new FirefoxDriver();
                driver.Navigate().GoToUrl(sws);


                driver.Navigate().GoToUrl(sws);
                var webElement = driver.FindElement(By.Name("personId"));
                webElement.SendKeys(studentNumber);
                webElement = driver.FindElement(By.Name("pin"));
                webElement.SendKeys(pin);
                webElement = driver.FindElement(By.CssSelector("input.button"));
                webElement.Click();

                driver.Navigate().GoToUrl(enrolmentPage);
                webElement = driver.FindElement(By.XPath("(//a[contains(text(),'Manage Courses')])[2]"));

                Thread.Sleep(TimeSpan.FromSeconds(3));
                webElement.Click();

                // supply course information for lookup
                webElement = driver.FindElement(By.Name("code"));
                webElement.SendKeys(course.getCourseCode());
                webElement = driver.FindElement(By.Name("sectionCode"));
                webElement.SendKeys(course.getSectionCode());
                webElement = driver.FindElement(By.XPath("//*[contains(@value,'Submit')]"));
                Thread.Sleep(TimeSpan.FromSeconds(3));
                webElement.Click();

                string page = driver.PageSource;
                string lectureSection = course.getLectureSection();
                lectureSection = lectureSection.Insert(3, ",");

                if (page.Contains("Add Meeting Section") && page.Contains(lectureSection))
                {
                    string sectionXPath = "//*[contains(@value,'" + lectureSection + "')]";
                    webElement = driver.FindElement(By.XPath(sectionXPath));
                    webElement.Click();

                    webElement = driver.FindElement(By.XPath("//*[contains(@value,'Add Meeting Sections')]"));
                    webElement.Click();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}