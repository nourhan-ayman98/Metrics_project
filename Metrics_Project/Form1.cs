﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrics_Project
{
    public partial class Form1 : Form
    {
        FunctionPoint f = new FunctionPoint();
        int index_of_datagridview = 1;
        public Form1()
        {

            InitializeComponent();
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           int reslut= f.calculate_UFP(int.Parse(Input_box.Text.ToString()), Input_CB.SelectedItem.ToString(),
                int.Parse(output_box.Text.ToString()),Output_CB.SelectedItem.ToString(),
                int.Parse(Query_box.Text.ToString()),Q_CB.SelectedItem.ToString()
                ,int.Parse(ILF_box.Text.ToString()),
                F_CB.SelectedItem.ToString(),int.Parse(EIF_box.Text.ToString()),I_CB.SelectedItem.ToString());

            UFP_box.Text = reslut.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
               
            }
        }
    }
}
