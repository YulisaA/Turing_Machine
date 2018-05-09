using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Touring_Machine_YulisaAzurdia1018516
{
    public partial class Form1 : Form
    {
        int actual_state = 0;
        int head = 0;
        int[] sumStates = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] subStates = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] multStates = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int[] pStates = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] pathStates = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int countSteps = 0;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersVisible = false;
            label1.Text = "";
            label2.Text = "";          
            label2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Palíndromo")
            {
                string text = textBox1.Text;
                text.Trim();
                var actualOne = text.ToArray();
                string[] array = new string[(text.Length) + 8];
                int i = 0;
                array[0] = "B";
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                this.dataGridView1.Rows[0].Cells[0].Value = array[0].ToString();
                dataGridView1.Columns[0].Width = 20;
                for (i = 0; i < actualOne.Length; i++)
                {
                    array[i + 1] = actualOne[i].ToString();
                    dataGridView1.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                    this.dataGridView1.Rows[0].Cells[i + 1].Value = array[i + 1];
                    dataGridView1.Columns[i + 1].Width = 20;
                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    array[k] = "B";
                    dataGridView1.Columns.Add(k.ToString(), "");
                    this.dataGridView1.Rows[0].Cells[k].Value = array[i + 1];
                    dataGridView1.Columns[k].Width = 20;
                }
                head = 1;
                timer1.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Patrones")
            {
                string text = textBox1.Text;
                text.Trim();
                var actualOne = text.ToArray();
                string[] array = new string[(text.Length)*2 + 4];
                int i = 0;
                array[0] = "B";
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                this.dataGridView1.Rows[0].Cells[0].Value = array[0].ToString();
                dataGridView1.Columns[0].Width = 20;
                for (i = 0; i < actualOne.Length; i++)
                {
                    array[i + 1] = actualOne[i].ToString();
                    dataGridView1.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                    this.dataGridView1.Rows[0].Cells[i + 1].Value = array[i + 1];
                    dataGridView1.Columns[i + 1].Width = 20;
                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    array[k] = "B";
                    dataGridView1.Columns.Add(k.ToString(), "");
                    this.dataGridView1.Rows[0].Cells[k].Value = array[i + 1];
                    dataGridView1.Columns[k].Width = 20;
                }
                head = 1;
                timer1.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Suma")
            {
                string text = textBox1.Text;
                text.Trim();
                var actualOne = text.ToArray();
                string[] array = new string[(text.Length) * 2];
                int i = 0;
                array[0] = "B";
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                this.dataGridView1.Rows[0].Cells[0].Value = array[0].ToString();
                dataGridView1.Columns[0].Width = 20;
                for (i = 0; i < actualOne.Length; i++)
                {
                    array[i+1] = actualOne[i].ToString();
                    dataGridView1.Columns.Add((i+1).ToString(), (i+1).ToString());
                    this.dataGridView1.Rows[0].Cells[i+1].Value = array[i+1];
                    dataGridView1.Columns[i+1].Width = 20;

                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    array[k] = "B";
                    dataGridView1.Columns.Add(k.ToString(), "");
                    this.dataGridView1.Rows[0].Cells[k].Value = array[i + 1];
                    dataGridView1.Columns[k].Width = 20;
                }
                timer1.Enabled = true;               
            }
            else if (comboBox1.SelectedItem.ToString() == "Multiplicación")
            {
                string text = textBox1.Text;
                text.Trim();
                var actualOne = text.ToArray();
                string[] array = new string[(text.Length) * (text.Length)];
                int i = 0;
                array[0] = "B";
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                this.dataGridView1.Rows[0].Cells[0].Value = array[0].ToString();
                dataGridView1.Columns[0].Width = 20;
                for (i = 0; i < actualOne.Length; i++)
                {
                    array[i + 1] = actualOne[i].ToString();
                    dataGridView1.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                    this.dataGridView1.Rows[0].Cells[i + 1].Value = array[i + 1];
                    dataGridView1.Columns[i + 1].Width = 20;

                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    array[k] = "B";
                    dataGridView1.Columns.Add(k.ToString(), "");
                    this.dataGridView1.Rows[0].Cells[k].Value = array[i + 1];
                    dataGridView1.Columns[k].Width = 20;
                }
                timer1.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Resta")
            {
                string text = textBox1.Text;
                text.Trim();
                var actualOne = text.ToArray();
                string[] array = new string[(text.Length) * 2];
                int i = 0;
                array[0] = "B";
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                this.dataGridView1.Rows[0].Cells[0].Value = array[0].ToString();
                dataGridView1.Columns[0].Width = 20;
                for (i = 0; i < actualOne.Length; i++)
                {
                    array[i + 1] = actualOne[i].ToString();
                    dataGridView1.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                    this.dataGridView1.Rows[0].Cells[i + 1].Value = array[i + 1];
                    dataGridView1.Columns[i + 1].Width = 20;

                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    array[k] = "B";
                    dataGridView1.Columns.Add(k.ToString(), "");
                    this.dataGridView1.Rows[0].Cells[k].Value = array[i + 1];
                    dataGridView1.Columns[k].Width = 20;
                }
                timer1.Enabled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Suma")
            {
                string position = dataGridView1.Rows[0].Cells[head].Value.ToString();

                switch (actual_state)
                {
                    case (0):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q1";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[1];
                        }
                        if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q0";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[0];
                        }
                        break;
                    case (1):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q1";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[1];
                        }
                        if (position == "+")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "+";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[2];
                        }
                        break;
                    case (2):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q3";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[3];
                        }
                        break;
                    case (3):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q3";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[3];
                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[4];
                        }
                        else if (position == "+")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "+";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[2];
                        }
                        break;
                    case (4):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[4];
                        }
                        if (position == "+")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "+";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[4];
                        }
                        if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[5];
                        }
                        break;
                    case (5):

                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "X";
                            head++;                           
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[6];

                        }
                        else if (position == "+")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "+";
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[5];
                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head--;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[8];

                            timer1.Enabled = false;
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[5];
                        }
                        break;
                    case (6):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[6];
                        }
                        else if (position == "+")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "+";
                            head++;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[6];

                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head++;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[6];

                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[7];
                        }
                        break;
                    case (7):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[7];
                        }
                        else if (position == "+")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "+";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[7];

                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[7];
                        }
                        else if (position == "X")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = sumStates[5];

                        }
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Resta")
            {
                string position = dataGridView1.Rows[0].Cells[head].Value.ToString();

                switch (actual_state)
                {
                    case (0):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q1";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[1];
                        }
                        if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q0";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[0];
                        }
                        break;
                    case (1):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q1";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[1];
                        }
                        if (position == "-")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "-";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[2];
                        }
                        break;
                    case (2):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q3";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[3];
                        }                        
                        break;
                    case (3):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q3";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[3];
                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[4];
                        }
                        else if (position == "-")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "-";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[2];
                        }
                        break;
                    case (4):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[4];
                        }
                        if (position == "-")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "-";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[4];
                        }
                        if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[5];
                        }
                        break;
                    case (5):

                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "X";
                            head++;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[6];

                        }
                        else if (position == "-")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "-";
                            head++;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[8];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[5];
                        }
                        break;
                    case (6):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[6];
                        }
                        else if (position == "-")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "-";
                            head++;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[6];

                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head++;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[6];

                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[7];
                        }
                        break;
                    case (7):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[7];
                        }
                        else if (position == "-")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "-";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[7];

                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[7];
                        }
                        else if (position == "X")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[5];
                        }
                        break;
                    case (8):
                        if (position == "-")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "-";
                            head++;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[8];
                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head--;
                            label1.Text = "q12";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[12];
                            timer1.Enabled = false;

                        }
                        else if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "X";
                            head++;
                            label1.Text = "q9";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[9];
                        }
                        break;
                    case (9):
                        if (position == "-")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "-";
                            head++;
                            label1.Text = "q9";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[9];
                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head++;
                            label1.Text = "q9";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[9];
                        }
                        else if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q9";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[9];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head--;
                            label1.Text = "q10";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[10];
                        }
                        break;
                    case (10):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head--;
                            label1.Text = "q11";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[11];
                        }
                        break;
                    case (11):
                        if (position == "-")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "-";
                            head--;
                            label1.Text = "q11";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[11];
                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head--;
                            label1.Text = "q11";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[11];
                        }
                        else if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head--;
                            label1.Text = "q11";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[11];
                        }
                        else if (position == "X")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = subStates[8];
                        }
                        break;                     
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Multiplicación")
            {
                string position = dataGridView1.Rows[0].Cells[head].Value.ToString();

                switch (actual_state)
                {
                    case (0):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q1";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[1];
                        }
                        if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q0";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[0];
                        }
                        break;
                    case (1):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q1";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[1];
                        }
                        if (position == "*")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "*";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[2];
                        }
                        break;
                    case (2):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q3";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[3];
                        }
                        break;
                    case (3):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q3";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[3];
                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[4];
                        }
                        else if (position == "*")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "*";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[2];
                        }
                        break;
                    case (4):
                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[4];
                        }
                        if (position == "*")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "*";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[4];
                        }
                        if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[5];
                        }
                        break;
                    case (5):

                        if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[5];
                        }
                        else if (position == "*")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "*";
                            head++;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[6];
                        }
                        break;
                    case (6):

                        if (position == "X" || position == "*" || position == "Y")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head++;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[6];
                        }
                        else if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "Y";
                            head++;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[6];
                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[7];
                        }
                        break;
                    case (7):

                        if (position == "X" )
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "X";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[7];
                        }
                        else if (position == "*")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "*";
                            head++;
                            label1.Text = "q12";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[12];
                        }
                        else if (position == "Y")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "X";
                            head--;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[8];
                        }
                        break;
                    case (8):

                        if (position == "X" || position == "*" || position == "Y" || position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head--;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[8];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q9";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[9];
                        }
                        break;
                    case (9):
                        if (position == "*")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "*";
                            head--;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[5];
                        }
                        else if (position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "Z";
                            head++;
                            label1.Text = "q10";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[10];
                        }
                        break;
                    case (10):
                        if (position == "*" || position == "|" || position == "=" || position == "Y" || position == "X")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head++;
                            label1.Text = "q10";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[10];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head--;
                            label1.Text = "q11";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[11];
                        }
                        break;
                    case (11):
                        if (position == "*" || position == "|" || position == "=" || position == "Y" || position == "X")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head--;
                            label1.Text = "q11";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[11];
                        }
                        else if (position == "Z")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q9";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[9];
                        }
                        break;
                    case (12):
                        if (position == "X")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q12";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[12];
                        }
                        else if (position == "=")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "=";
                            head--;
                            label1.Text = "q13";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[13];
                        }
                        break;
                    case (13):
                        if (position == "*" || position == "|")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head--;
                            label1.Text = "q13";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[13];
                        }
                        else if (position == "X")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "|";
                            head++;
                            label1.Text = "q13";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[13];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head+1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q14";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = multStates[14];
                        }
                        break;
                    case (14):                        
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;

                            timer1.Enabled = false;                        
                        break;
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Palíndromo")
            {
                string position = dataGridView1.Rows[0].Cells[head].Value.ToString();

                switch (actual_state)
                {
                    case (0):
                        if (position == "a")
                        {                           
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;                                                      
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q1";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[1];
                        }
                        else if (position == "b")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[2];
                        }
                        else if (position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q3";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[3];
                        }
                        else if (position == "B")
                        {                           
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[8];

                        }
                        break;
                    case (1):
                        if (position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head++;
                            label1.Text = "q1";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[1];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[4];
                        }
                        break;
                    case (2):
                        if (position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[2];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head--;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[5];
                        }
                        break;
                    case (3):
                        if (position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head++;
                            label1.Text = "q3";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[3];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head--;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[6];
                        }
                        break;
                    case (4):
                        if (position == "a")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[7];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[8];
                        }
                        break;
                    case (5):
                        if (position == "b")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[7];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[8];
                        }
                        break;
                    case (6):
                        if (position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[7];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[8];
                        }
                        break;
                    case (7):
                        if (position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head--;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[7];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q0";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pStates[0]; 
                        }
                        break;
                    case (8):
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            
                            timer1.Enabled = false;
                        break;
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Patrones")
            {
                string position = dataGridView1.Rows[0].Cells[head].Value.ToString();

                switch (actual_state)
                {
                    case (0):
                        if (position == "a")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "X";
                            head++;
                            label1.Text = "q0";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[0];
                        }
                        else if (position == "b")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "Y";
                            head++;
                            label1.Text = "q0";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[0];
                        }
                        else if (position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "Z";
                            head++;
                            label1.Text = "q0";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[0];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head--;
                            label1.Text = "q1";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[1];
                        }
                        break;
                    case (1):
                        if (position == "X" || position == "Y" || position == "Z")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head--;
                            label1.Text = "q1";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[1];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[2];
                        }
                        break;
                    case (2):
                        if (position == "X")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "a";
                            head++;
                            label1.Text = "q3";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[3];
                        }
                        else if (position == "Y")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "b";
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[5];
                        }
                        else if (position == "Z")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "c";
                            head++;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[7];
                        }
                        else if (position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[2];                            
                        }

                        else if (position == "B")
                        {                           
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head--;
                            label1.Text = "q9";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[9];                           
                        }
                        break;
                    case (3):
                        if (position == "X" || position == "Y" || position == "Z" || position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head++;
                            label1.Text = "q3";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[3];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "a";
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[4];
                        }
                        break;
                    case (5):
                        if (position == "X" || position == "Y" || position == "Z" || position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head++;
                            label1.Text = "q5";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[5];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "b";
                            head--;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[6];
                        }
                        break;
                    case (7):
                        if (position == "X" || position == "Y" || position == "Z" || position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head++;
                            label1.Text = "q7";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[7];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = "c";
                            head--;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[8];
                        }
                        break;
                    case (4):
                        if (position == "X" || position == "Y" || position == "Z" || position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head--;
                            label1.Text = "q4";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[4];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[2];
                        }
                        break;
                    case (6):
                        if (position == "X" || position == "Y" || position == "Z" || position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head--;
                            label1.Text = "q6";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[6];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[2];
                        }
                        break;
                    case (8):
                        if (position == "X" || position == "Y" || position == "Z" || position == "a" || position == "b" || position == "c")
                        {
                            dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                            dataGridView1.Rows[0].Cells[head].Value = position;
                            head--;
                            label1.Text = "q8";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[8];
                        }
                        else if (position == "B")
                        {
                            dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                            dataGridView1.Rows[0].Cells[head].Value = "B";
                            head++;
                            label1.Text = "q2";
                            countSteps++;
                            label2.Text = countSteps.ToString();
                            actual_state = pathStates[2];
                        }
                        break;
                    case (9):
                        dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        timer1.Enabled = false;
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
