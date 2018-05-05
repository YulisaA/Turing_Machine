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
        int[] sumStates = new int[] { 0, 1, 2, 3 };

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersVisible = false;
            label1.Text = "";

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Palíndromo")
            {
                MessageBox.Show("");
            }
            else if (comboBox1.SelectedItem.ToString() == "Patrones")
            {
                MessageBox.Show("");
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
                MessageBox.Show("");
            }
            else if (comboBox1.SelectedItem.ToString() == "Resta")
            {
                MessageBox.Show("");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string position = dataGridView1.Rows[0].Cells[head].Value.ToString();

            switch (actual_state)
            {
                case (0):
                    
                    if (position == "|")
                    {
                        dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows[0].Cells[head].Value = "X";                       
                        head++;
                        label1.Text = "q1";
                        actual_state = sumStates[1];
                        
                    }
                    else if (position == "+")
                    {
                        dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows[0].Cells[head].Value = "+";
                        head++;
                        label1.Text = "q0";
                        actual_state = sumStates[0];
                    }
                    else if (position == "=")
                    {
                        dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows[0].Cells[head].Value = "=";                        
                        head--;
                        label1.Text = "q3";
                        actual_state = sumStates[3];
                        
                        timer1.Enabled = false;
                    }
                    else if (position == "B")
                    {                       
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Value = "B";
                        head++;
                        label1.Text = "q0";
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
                        actual_state = sumStates[1];
                    }
                    else if (position == "+")
                    {
                        dataGridView1.Rows[0].Cells[head-1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows[0].Cells[head].Value = "+";
                        head++;
                        label1.Text = "q1";
                        actual_state = sumStates[1];
                        
                    }
                    else if (position == "=")
                    {
                        dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows[0].Cells[head].Value = "=";
                        head++;
                        label1.Text = "q1";
                        actual_state = sumStates[1];
                        
                    }
                    else if (position == "B")
                    {
                        dataGridView1.Rows[0].Cells[head - 1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows[0].Cells[head].Value = "|";
                        head--;
                        label1.Text = "q2";
                        actual_state = sumStates[2];                        
                    }
                    break;
                case (2):
                    if (position == "|")
                    {
                        dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows[0].Cells[head].Value = "|";
                        head--;
                        label1.Text = "q2";
                        actual_state = sumStates[2];                       
                    }
                    else if (position == "+")
                    {
                        dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows[0].Cells[head].Value = "+";
                        head--;
                        label1.Text = "q2";
                        actual_state = sumStates[2];
                        
                    }
                    else if (position == "=")
                    {
                        dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows[0].Cells[head].Value = "=";
                        head--;
                        label1.Text = "q2";
                        actual_state = sumStates[2];
                    }
                    else if (position == "X")
                    {
                        dataGridView1.Rows[0].Cells[head + 1].Style.BackColor = Color.White;
                        dataGridView1.Rows[0].Cells[head].Style.BackColor = Color.Aqua;
                        dataGridView1.Rows[0].Cells[head].Value = "|";
                        head++;
                        label1.Text = "q0";
                        actual_state = sumStates[0];
                        
                    }
                    break;

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
