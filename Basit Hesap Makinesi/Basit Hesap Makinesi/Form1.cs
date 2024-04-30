using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
        }

        private void buttonesittir_Click(object sender, EventArgs e)
        {
            textBoxhistory.Text = Operations.view+"=";
            Operations.Process();
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void buttontoplam_Click(object sender, EventArgs e)
        {
            Operations.Add("+");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void buttoneksi_Click(object sender, EventArgs e)
        {

            Operations.Add("-");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void buttoncarpim_Click(object sender, EventArgs e)
        {

            Operations.Add("*");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void buttonbolum_Click(object sender, EventArgs e)
        {
            Operations.Add("/");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Operations.Add("0");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations.Add("1");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operations.Add("2");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operations.Add("3");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operations.Add("4");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Operations.Add("5");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Operations.Add("6");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Operations.Add("7");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Operations.Add("8");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Operations.Add("9");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void buttonnokta_Click(object sender, EventArgs e)
        {
            Operations.Add(".");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void buttonac_Click(object sender, EventArgs e)
        {
          
            Operations.Add("C");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();

        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            Operations.Add("del");
            textBox1.Text = Operations.view;
            textBoxfocus.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13 : buttonesittir.PerformClick(); break;
                case (char)48: button0.PerformClick(); break;
                case (char)49: button1.PerformClick(); break;
                case (char)50: button2.PerformClick(); break;
                case (char)51: button3.PerformClick(); break;
                case (char)52: button4.PerformClick(); break;
                case (char)53: button5.PerformClick(); break;
                case (char)54: button6.PerformClick(); break;
                case (char)55: button7.PerformClick(); break;
                case (char)56: button8.PerformClick(); break;
                case (char)57: button9.PerformClick(); break;
                case (char)08: buttonc.PerformClick(); break;
                case (char)44: buttonnokta.PerformClick(); break;
                case (char)42: buttoncarpim.PerformClick(); break;
                case (char)47: buttonbolum.PerformClick(); break;
                case (char)43: buttontoplam.PerformClick(); break;
                case (char)45: buttoneksi.PerformClick(); break;

            }
            e.Handled =  true;
        }
    }
}
