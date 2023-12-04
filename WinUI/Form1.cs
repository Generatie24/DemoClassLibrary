using LibCalculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            double result = cal.Add(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            
            ShowResult(result);

        }

        private void ShowResult(double result)
        {
            Calculator cal = new Calculator();
            txtResult.Text = result.ToString();
            txtResult.ReadOnly = true;
            Calculator.Total += double.Parse(txtResult.Text);
            txtTotal.Text = Calculator.Total.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double result = calculator.Subtract(double.Parse(txtFirstNumber.Text), double.Parse(txtSecondNumber.Text));
            ShowResult(result);
        }

       
    }
}
