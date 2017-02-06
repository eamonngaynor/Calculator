using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Eamonn Gaynor
// C00197458
// 20/09/2016
// A simple Calculator.

namespace Calculator
{

    public partial class Form1 : Form
    {
        String operand = ""; //declaring operand
        double result; //declaring result


        public Form1()
        {
            //Initializing form
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Loading Form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //On a click, this button will change the text box to the correspoding integer.
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //On a click, this button will change the text box to the correspoding integer.
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //On a click, this button will change the text box to the correspoding integer.
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //On a click, this button will change the text box to the correspoding integer.
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //On a click, this button will change the text box to the correspoding integer.
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //On a click, this button will change the text box to the correspoding integer.
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //On a click, this button will change the text box to the correspoding integer.
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //On a click, this button will change the text box to the correspoding integer.
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //On a click, this button will change the text box to the correspoding integer.
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //On a click, this button will change the text box to the correspoding integer.   
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //setting the textbox and equation label to null, as the clear button has been clicked
            textBox1.Text = "";
            equation.Text = "";



        }

        private void add_Click(object sender, EventArgs e)
        {

            if (equation.Text != "") //determining whether the equation label already contains value
            {
                result = Convert.ToDouble(equation.Text) + Convert.ToDouble(textBox1.Text);
                // result is equal to the equation of the two values
                textBox1.Text = Convert.ToString(result);
                // the textbox is assigned to the result
                equation.Text = "";
                //equation is now blank 
                operand = "+";
                //operand is set for equals function
            }

            if (equation.Text == "") //if equation label is blank 
            {
                equation.Text = textBox1.Text;
                //equation is now assigned what was in the textbox
                textBox1.Text = "";
                //textbox set to blank 
                operand = "+";
                //operand is set for equals function               
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (operand == "+") //if operand is equal to 'plus'
            {
                result = Convert.ToDouble(equation.Text) + Convert.ToDouble(textBox1.Text);
                //result is equal to the equation of the textbox and equation box
                textBox1.Text = Convert.ToString(result);
                //textbox is assigned the string result
                equation.Text = "";
                operand = "";
                //equation and operand is set to blank
            }

            if (operand == "-") //if operand is equal to 'minus'
            {
                result = Convert.ToDouble(equation.Text) - Convert.ToDouble(textBox1.Text);
                //result is equal to the equation of the textbox and equation box
                textBox1.Text = Convert.ToString(result);
                //textbox is assigned the string result
                equation.Text = "";
                operand = "";
                //equation and operand is set to blank
            }

            if (operand == "/") //if operand is equal to 'divide'
            {
                result = Convert.ToDouble(equation.Text) / Convert.ToDouble(textBox1.Text);
                //result is equal to the equation of the textbox and equation box
                textBox1.Text = Convert.ToString(result);
                //textbox is assigned the string result
                equation.Text = "";
                operand = "";
                //equation and operand is set to blank
            }

            if (operand == "*") //if operand is equal to 'multiply'
            {
                result = Convert.ToDouble(equation.Text) * Convert.ToDouble(textBox1.Text);
                //result is equal to the equation of the textbox and equation box
                textBox1.Text = Convert.ToString(result);
                //textbox is assigned the string result
                equation.Text = "";
                operand = "";
                //equation and operand is set to blank
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {

            if (equation.Text != "") //determining whether the equation label already contains value
            {
                result = Convert.ToDouble(equation.Text) - Convert.ToDouble(textBox1.Text);
                // result is equal to the equation of the two values
                textBox1.Text = Convert.ToString(result);
                // the textbox is assigned to the result
                equation.Text = "";
                //equation is now blank 
                operand = "-";
                //operand is set for equals function
            }

            if (equation.Text == "") //if equation label is blank 
            {
                equation.Text = textBox1.Text;
                //equation is now assigned what was in the textbox
                textBox1.Text = "";
                //textbox set to blank 
                operand = "-";
                //operand is set for equals function               
            }

        }
        private void divide_Click(object sender, EventArgs e)
        {
            if (equation.Text != "") //determining whether the equation label already contains value
            {
                result = Convert.ToDouble(equation.Text) / Convert.ToDouble(textBox1.Text);
                // result is equal to the equation of the two values
                textBox1.Text = Convert.ToString(result);
                // the textbox is assigned to the result
                equation.Text = "";
                //equation is now blank 
                operand = "/";
                //operand is set for equals function
            }

            if (equation.Text == "") //if equation label is blank 
            {
                equation.Text = textBox1.Text;
                //equation is now assigned what was in the textbox
                textBox1.Text = "";
                //textbox set to blank 
                operand = "/";
                //operand is set for equals function               
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (equation.Text != "") //determining whether the equation label already contains value
            {
                result = Convert.ToDouble(equation.Text) * Convert.ToDouble(textBox1.Text);
                // result is equal to the equation of the two values
                textBox1.Text = Convert.ToString(result);
                // the textbox is assigned to the result
                equation.Text = "";
                //equation is now blank 
                operand = "*";
                //operand is set for equals function
            }

            if (equation.Text == "") //if equation label is blank 
            {
                equation.Text = textBox1.Text;
                //equation is now assigned what was in the textbox
                textBox1.Text = "";
                //textbox set to blank 
                operand = "*";
                //operand is set for equals function               
            }

        }


    }
}
