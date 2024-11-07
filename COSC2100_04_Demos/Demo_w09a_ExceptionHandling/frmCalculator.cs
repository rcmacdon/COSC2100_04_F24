using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_w09a_ExceptionHandling
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double answer = 0;
            bool valid = true;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "+":
                    answer = MyMath.Add((double)nud1.Value, (double)nud2.Value);
                    break;
                case "-":
                    answer = MyMath.Subtract((double)nud1.Value, (double)nud2.Value);
                    break;
                case "*":
                    answer = MyMath.Multiply((double)nud1.Value, (double)nud2.Value);
                    break;
                case "/":
                    try
                    {
                        answer = MyMath.Divide((double)nud1.Value, (double)nud2.Value);
                    }
                    catch (DivideByZeroException ex)
                    {
                        lblMessage.Text = ex.Message;
                        valid = false;
                    }
                    break;
                case "x^y":
                    answer = MyMath.Power((double)nud1.Value, (double)nud2.Value);
                    break;
                case "sqrt":
                    try
                    {
                        answer = MyMath.Sqrt((double)nud1.Value);
                    }
                    catch (ArithmeticException ex)
                    {
                        lblMessage.Text = ex.Message + ' ' + ex.StackTrace;
                        valid = false;
                    }
                    catch (Exception ex)
                    {
                        lblMessage.Text = "a general error occured, try again!";
                        valid = false;
                    }
                    finally
                    {

                    }
                    break;
            }

            if (valid) lblAnswer.Text = answer.ToString();
            else lblAnswer.Text = "error";
        }
    }
}
