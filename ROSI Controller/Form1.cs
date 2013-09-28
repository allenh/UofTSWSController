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
        protected string pinNumber;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            studentNumber = studentNum.Text;
            pinNumber = pin.Text;
        }
    }
}