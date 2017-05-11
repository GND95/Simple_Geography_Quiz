using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographyProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 500;
            button1.Location = new Point(100, 75);
            button1.Text = "Start Quiz!";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            label2.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
        }
        float correct = 0f; //values to be used to grade the quiz
        int counter = 0; // this is what will keep track of what question you are on so it can switch to the next one once the user presses the button
        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = true; //re-enables crossed out answers for the next question
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;

            if (counter == 1 && radioButton4.Checked == true)
            {
                correct++;
            }
            if (counter == 2 && radioButton2.Checked == true)
            {
                correct++;
            }
            if (counter == 3 && radioButton4.Checked == true)
            {
                correct++;
            }
            if (counter == 4 && radioButton1.Checked == true)
            {
                correct++;
            }
            if (counter == 5 && radioButton3.Checked == true)
            {
                correct++;
            }
            if (counter == 6 && radioButton4.Checked == true)
            {
                correct++;
            }
            if (counter == 7 && radioButton2.Checked == true)
            {
                correct++;
            }
            if (counter == 8 && radioButton1.Checked == true)
            {
                correct++;
            }
            counter++; //increment the counter each time the button is presses so the program knows what question it needs to display

            this.Width = 888;
            button1.Location = new Point(599, 12);
            label2.Visible = true;
            label1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            if (counter == 1)
            {
                label2.Text = "How many countries are in \r\nEurope?";
                button1.Text = "Next Question";
                label1.Text = "Question\r\n1";
                radioButton1.Text = "28";
                radioButton2.Text = "51";
                radioButton3.Text = "36";
                radioButton4.Text = "44";
            }
            if (counter == 2)
            {
                label2.Text = "How many countries are in \r\nAsia?";
                label1.Text = "Question\r\n2";
                label3.Visible = true;
                label4.Visible = true;
                label4.Text = correct + "/8\r\nCorrect";
                radioButton1.Text = "35";
                radioButton2.Text = "48";
                radioButton3.Text = "62";
                radioButton4.Text = "54";
            }
            if (counter == 3)
            {
                label2.Text = "How many countries are in \r\nAntarctica?";
                label1.Text = "Question\r\n3";
                label4.Text = correct + "/8\r\nCorrect";
                radioButton1.Text = "1";
                radioButton2.Text = "2";
                radioButton3.Text = "6";
                radioButton4.Text = "0";
            }
            if (counter == 4)
            {
                label2.Text = "How many countries are in \r\nNorth America?";
                label1.Text = "Question\r\n4";
                label4.Text = correct + "/8\r\nCorrect";
                radioButton1.Text = "23";
                radioButton2.Text = "3";
                radioButton3.Text = "17";
                radioButton4.Text = "11";
            }
            if (counter == 5)
            {
                label2.Text = "How many countries are in \r\nSouth America?";
                label1.Text = "Question\r\n5";
                label4.Text = correct + "/8\r\nCorrect";
                radioButton1.Text = "8";
                radioButton2.Text = "15";
                radioButton3.Text = "12";
                radioButton4.Text = "19";
            }
            if (counter == 6)
            {
                label2.Text = "How many countries are in \r\nAfrica?";
                label1.Text = "Question\r\n6";
                label4.Text = correct + "/8\r\nCorrect";
                radioButton1.Text = "68";
                radioButton2.Text = "39";
                radioButton3.Text = "27";
                radioButton4.Text = "54";
            }
            if (counter == 7)
            {
                label2.Text = "How many countries are in \r\nAustralia?";
                label1.Text = "Question\r\n7";
                label4.Text = correct + "/8\r\nCorrect";
                radioButton1.Text = "3";
                radioButton2.Text = "1";
                radioButton3.Text = "5";
                radioButton4.Text = "0";
            }
            if (counter == 8)
            {
                label2.Text = "How many total countries\r\nare there in the world?";
                label1.Text = "Question\r\n8";
                radioButton1.Text = "196";
                radioButton2.Text = "301";
                radioButton3.Text = "155";
                radioButton4.Text = "113";
                label4.Text = correct + "/8\r\nCorrect";
                button1.Text = "Click to Finish";
            }
            if (counter == 9)
            {
                float grade = correct / (counter - 1);
                label3.Text += "\r\n" + grade * 100 + "%\r\nGrade:";
                label4.Text = correct + "/8\r\nCorrect";
                button1.Text = "Click to Retry";
                if (grade > .894)
                {
                    label3.Text += " A";
                }
                else
                {
                    if (grade > .794)
                    {
                        label3.Text += " B";
                    }
                    else
                    {
                        if (grade > .694)
                        {
                            label3.Text += " C";
                        }
                        else
                        {
                            if (grade > .594)
                            {
                                label3.Text += " D";
                            }
                            else
                            {
                                if (grade <= .594)
                                {
                                    label3.Text += " F";
                                }
                            }
                        }
                    }
                }
            }

            if (counter == 10)
            {
                Application.Restart();
            }
        }

        //section for right click disabling of answers
        private void l_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                radioButton1.Enabled = false;
            }
        }
        private void radioButton2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                radioButton2.Enabled = false;
            }
        }
        private void radioButton3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                radioButton3.Enabled = false;
            }
        }
        private void radioButton4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                radioButton4.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
        }
    }
}


