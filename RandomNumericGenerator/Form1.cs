using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumericGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Generate
        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            int minNum = (int)numericUpDown1.Value;
            int maxNum = (int)numericUpDown2.Value;
            // if numeric is not set.
            if (minNum == 0 && maxNum == 0)
            {
                info("Please enter the numeric.");
                return;
            }
            // if numeric is limit numeric set.
            if (minNum > 100000000 || maxNum > 100000000)
            {
                info("Sorry, The limit of the numeric is 100,000,000.");
                return;
            }
            // if ..... :(
            if (minNum > maxNum)
            {
                info("The maximum numeric is lower than the minimum numeric.");
                return;
            }
            // if both numerics is set to same numeric
            if (minNum == maxNum)
            {
                info("The both numerics is also the same.");
                return;
            }
            // if numeric is good numeric set
            if (minNum < maxNum)
            {
                textBox1.Text = rand.Next(minNum, maxNum + 1).ToString();
                return;
            }
        }

        // Copy the numeric(in clipboard)
        private void button2_Click_1(object sender, EventArgs e)
        {
            copy(textBox1);
        }

        private void error(String message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            reset();
        }

        private void info(String message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
        }

        private void reset()
        {
            textBox1.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown1.Focus();
        }

        private void copy(TextBox box)
        {
            box.SelectAll();
            box.Copy();
        }
    }
}
