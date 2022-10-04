using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }
        private void input(string btn)
        {
            if(lblResult.Text == "0")
            {
                lblResult.Text = btn;
            }
            else
            {
                lblResult.Text += btn;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            input("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input("9");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            lblPrevious.Text += lblResult.Text + "+";
            lblResult.Text = "";
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            lblPrevious.Text += lblResult.Text + "-";
            lblResult.Text = "";
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            lblPrevious.Text += lblResult.Text + "*";
            lblResult.Text = "";
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            lblPrevious.Text += lblResult.Text + "/";
            lblResult.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input("0");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            if (lblResult.Text.Length <= 0)
            {
                lblResult.Text = "0";
            }
            lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            calc.Hesapla();
        }
    }
}
