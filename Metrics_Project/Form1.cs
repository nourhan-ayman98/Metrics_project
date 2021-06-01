using System;
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
        DataTable d = new DataTable();
        int rowindex=0;
        DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
        
        public Form1()
        {

            InitializeComponent();
            d.Columns.Add("ID", typeof(int));
            d.Columns.Add("Technical Factors", typeof(string));
            dataGridView1.DataSource = d;
            d.Rows.Add();
            d.Rows[0]["ID"] = index_of_datagridview;
            combo.HeaderText = "Rates";
            combo.Name = "combo";
            List<String> l = new List<String>();
            List<KeyValuePair<string, int>> GSC = FunctionPoint.GSC;
            for(int i = 0; i < 5; i++)
            {
                l.Add(GSC[i].Key);
            }
            combo.Items.AddRange(l.ToArray());

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
            if (e.KeyCode==Keys.Enter)
            {
                d.Rows.Add();
                int n = d.Rows.Count;
                n--;
                index_of_datagridview++;
                d.Rows[n]["ID"] = index_of_datagridview;
            }

            if (e.KeyCode == Keys.Delete)
            {
                index_of_datagridview--;
                int k = index_of_datagridview;
                d.Rows.RemoveAt(rowindex);
                for(int i=d.Rows.Count-1; i >= 0; i--)
                {
                    d.Rows[i]["ID"] = k;
                    k--;
                }
               
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = dataGridView1.CurrentRow.Index;
        }

        private void show_factors_Click(object sender, EventArgs e)
        {
            int index = 1;
            DataRow dr = null;
            d.Rows.Clear();
            dataGridView1.Columns.Add(combo);
            //1 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Data Communication";
            index++;
            d.Rows.Add(dr);
            //2 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Distributed Data Processing";
            index++;
            d.Rows.Add(dr);
            //3 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Performance Criteria";
            index++;
            d.Rows.Add(dr);
            //4 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Heavily Utilized Hardware";
            index++;
            d.Rows.Add(dr);
            //5 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "High Transaction Rates";
            index++;
            d.Rows.Add(dr);
            //6 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Online Data Entry";
            index++;
            d.Rows.Add(dr);
            //7 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Online Updating";
            index++;
            d.Rows.Add(dr);
            //8 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "End-User Efficiency";
            index++;
            d.Rows.Add(dr);
            //9 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Complex Computations";
            index++;
            d.Rows.Add(dr);
            //10 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Reusability";
            index++;
            d.Rows.Add(dr);
            //11 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Ease of Installation";
            index++;
            d.Rows.Add(dr);
            //12 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Ease of Operation";
            index++;
            d.Rows.Add(dr);
            //13 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Portability";
            index++;
            d.Rows.Add(dr);
            //14 factor
            dr = d.NewRow();
            dr["ID"] = index;
            dr["Technical Factors"] = "Maintainability";
            index++;
            d.Rows.Add(dr);
        }

        private void put_rate_to_all_factors_Click(object sender, EventArgs e)
        {
            Panel pan
        }
    }
}
