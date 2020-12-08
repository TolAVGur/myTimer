using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTimer
{
    public partial class FormMain : Form
    {
        private string alarmTime;
        public FormMain()
        {
            InitializeComponent();
            DisplayCarrentTime();
        }

        private void DisplayCarrentTime()
        {
            label.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            alarmTime = textBox.Text;
            MessageBox.Show($"Stert alarm - {alarmTime}", "Warning", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            alarmTime = "";
            textBox.Clear();
            MessageBox.Show($"Stop alarm!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DisplayCarrentTime();
            if (label.Text == alarmTime)
            {
                MessageBox.Show($"Time is up!", "Information",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
