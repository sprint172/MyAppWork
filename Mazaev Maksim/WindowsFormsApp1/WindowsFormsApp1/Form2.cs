using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public Form2(string windowTitle, string message)
        {
            InitializeComponent();
            this.Text = windowTitle;
            label1.Text = message;

        }

        public static string Show(string windowTitle, string message)
        {
            using (Form2 inputOlg = new Form2(windowTitle, message))
            {
                inputOlg.ShowDialog();
                return inputOlg.textBox1.Text;
            }


        }
       
    }
}


