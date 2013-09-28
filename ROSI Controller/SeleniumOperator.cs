using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ROSI_Controller
{
    class SeleniumOperator
    {
        public string id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string pin
        {
            get { return this.pin; }
            set { this.pin = value; }
        }


        private readonly string sws = "https://sws.rosi.utoronto.ca";
        private readonly string enrolmentPage = "https://sws.rosi.utoronto.ca/sws/reg/main.do?main.dispatch";
        public void continuousAddCourse(Course c)
        {
            FirefoxDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(sws);
            
        }
    }
}