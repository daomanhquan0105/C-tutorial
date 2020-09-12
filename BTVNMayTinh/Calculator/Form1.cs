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
        double resultValue = 0;//biến chứa kết quả giá trị
        string operationPerformed="";//biến thực hiện thao tác
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }//rong
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1_Result.Text == "0" || (isOperationPerformed))
            {
                textBox1_Result.Clear();
            }
            textBox1_Result.Text = textBox1_Result.Text + button.Text;
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button19.PerformClick();
                operationPerformed = button.Text;//thực hiện sao chép ở nút bấm txt
                labelCurrentOperation.Text = resultValue.ToString() + " " + operationPerformed;
                isOperationPerformed = true;
             }
            else
            {
                
                operationPerformed = button.Text;//thực hiện sao chép ở nút bấm txt
                resultValue = double.Parse(textBox1_Result.Text);//chuyển đổi văn bản trong textbox thành giá trị
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if(textBox1_Result.Text.Length > 0)
            {
                textBox1_Result.Text = textBox1_Result.Text.Remove(textBox1_Result.Text.Length - 1);
            }
            if(textBox1_Result.Text.Length==0)
            {
                textBox1_Result.Text = "0";
            }
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
            resultValue = 0;
        }
        private void Button19_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)//biểu thức hoặc kiểu dữ liệu
            {
                case "+" :    
                    textBox1_Result.Text = (resultValue + double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "-":
                    textBox1_Result.Text = (resultValue - double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "*":
                    textBox1_Result.Text = (resultValue * double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "/":
                    textBox1_Result.Text = (resultValue / double.Parse(textBox1_Result.Text)).ToString();
                    break; 
            }
            labelCurrentOperation.Text = "";
            if(isOperationPerformed) resultValue = double.Parse(textBox1_Result.Text);
            else resultValue = 0;
            isOperationPerformed = true;

        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(textBox1_Result.Text);
            labelCurrentOperation.Text = System.Convert.ToString("sqrt(" + (textBox1_Result.Text) + ")");
            sq = Math.Sqrt(sq);
            textBox1_Result.Text = System.Convert.ToString(sq);
        }  

        private void exp_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1_Result.Text);
            labelCurrentOperation.Text = System.Convert.ToString("e^" + i);
            textBox1_Result.Text = System.Convert.ToString(Math.Exp(i));

        }

        private void sqr_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1_Result.Text);
            labelCurrentOperation.Text = System.Convert.ToString(i + "^2");
            textBox1_Result.Text = System.Convert.ToString(Math.Pow(i, 2));
        }
    }
}
