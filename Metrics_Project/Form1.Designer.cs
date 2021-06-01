namespace Metrics_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Query_box = new System.Windows.Forms.TextBox();
            this.output_box = new System.Windows.Forms.TextBox();
            this.ILF_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EIF_box = new System.Windows.Forms.TextBox();
            this.calc_ufp = new System.Windows.Forms.Button();
            this.UFP_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Input_CB = new System.Windows.Forms.ComboBox();
            this.Output_CB = new System.Windows.Forms.ComboBox();
            this.Q_CB = new System.Windows.Forms.ComboBox();
            this.I_CB = new System.Windows.Forms.ComboBox();
            this.F_CB = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.own_factors_bttn = new System.Windows.Forms.Button();
            this.show_factors = new System.Windows.Forms.Button();
            this.put_rate_to_all_factors = new System.Windows.Forms.Button();
            this.panel_factors = new System.Windows.Forms.Panel();
            this.rate_Box_all = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_factors.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_box
            // 
            this.Input_box.Location = new System.Drawing.Point(204, 29);
            this.Input_box.Name = "Input_box";
            this.Input_box.Size = new System.Drawing.Size(153, 20);
            this.Input_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "External Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "External Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(20, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "External Inquiry ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(20, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Internal Logical Files";
            // 
            // Query_box
            // 
            this.Query_box.Location = new System.Drawing.Point(210, 141);
            this.Query_box.Name = "Query_box";
            this.Query_box.Size = new System.Drawing.Size(153, 20);
            this.Query_box.TabIndex = 6;
            this.Query_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // output_box
            // 
            this.output_box.Location = new System.Drawing.Point(204, 81);
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(153, 20);
            this.output_box.TabIndex = 7;
            // 
            // ILF_box
            // 
            this.ILF_box.Location = new System.Drawing.Point(284, 225);
            this.ILF_box.Name = "ILF_box";
            this.ILF_box.Size = new System.Drawing.Size(153, 20);
            this.ILF_box.TabIndex = 8;
            this.ILF_box.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "External Interface Files ";
            // 
            // EIF_box
            // 
            this.EIF_box.Location = new System.Drawing.Point(284, 279);
            this.EIF_box.Name = "EIF_box";
            this.EIF_box.Size = new System.Drawing.Size(153, 20);
            this.EIF_box.TabIndex = 10;
            // 
            // calc_ufp
            // 
            this.calc_ufp.BackColor = System.Drawing.Color.Black;
            this.calc_ufp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.calc_ufp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calc_ufp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_ufp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calc_ufp.Location = new System.Drawing.Point(244, 389);
            this.calc_ufp.Name = "calc_ufp";
            this.calc_ufp.Size = new System.Drawing.Size(128, 52);
            this.calc_ufp.TabIndex = 11;
            this.calc_ufp.Text = "Calculate UFP";
            this.calc_ufp.UseVisualStyleBackColor = false;
            this.calc_ufp.Click += new System.EventHandler(this.button1_Click);
            // 
            // UFP_box
            // 
            this.UFP_box.Location = new System.Drawing.Point(67, 442);
            this.UFP_box.Name = "UFP_box";
            this.UFP_box.Size = new System.Drawing.Size(153, 20);
            this.UFP_box.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(62, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "UFP ";
            // 
            // Input_CB
            // 
            this.Input_CB.FormattingEnabled = true;
            this.Input_CB.Items.AddRange(new object[] {
            "Simple",
            "Averge",
            "Complex"});
            this.Input_CB.Location = new System.Drawing.Point(403, 29);
            this.Input_CB.Name = "Input_CB";
            this.Input_CB.Size = new System.Drawing.Size(98, 21);
            this.Input_CB.TabIndex = 14;
            // 
            // Output_CB
            // 
            this.Output_CB.FormattingEnabled = true;
            this.Output_CB.Items.AddRange(new object[] {
            "Simple",
            "Averge",
            "Complex"});
            this.Output_CB.Location = new System.Drawing.Point(403, 82);
            this.Output_CB.Name = "Output_CB";
            this.Output_CB.Size = new System.Drawing.Size(98, 21);
            this.Output_CB.TabIndex = 15;
            // 
            // Q_CB
            // 
            this.Q_CB.FormattingEnabled = true;
            this.Q_CB.Items.AddRange(new object[] {
            "Simple",
            "Averge",
            "Complex"});
            this.Q_CB.Location = new System.Drawing.Point(403, 141);
            this.Q_CB.Name = "Q_CB";
            this.Q_CB.Size = new System.Drawing.Size(98, 21);
            this.Q_CB.TabIndex = 16;
            // 
            // I_CB
            // 
            this.I_CB.FormattingEnabled = true;
            this.I_CB.Items.AddRange(new object[] {
            "Simple",
            "Averge",
            "Complex"});
            this.I_CB.Location = new System.Drawing.Point(474, 280);
            this.I_CB.Name = "I_CB";
            this.I_CB.Size = new System.Drawing.Size(98, 21);
            this.I_CB.TabIndex = 17;
            // 
            // F_CB
            // 
            this.F_CB.FormattingEnabled = true;
            this.F_CB.Items.AddRange(new object[] {
            "Simple",
            "Averge",
            "Complex"});
            this.F_CB.Location = new System.Drawing.Point(474, 219);
            this.F_CB.Name = "F_CB";
            this.F_CB.Size = new System.Drawing.Size(98, 21);
            this.F_CB.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(621, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 354);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // own_factors_bttn
            // 
            this.own_factors_bttn.BackColor = System.Drawing.Color.Black;
            this.own_factors_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.own_factors_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.own_factors_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.own_factors_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.own_factors_bttn.Location = new System.Drawing.Point(1466, 49);
            this.own_factors_bttn.Name = "own_factors_bttn";
            this.own_factors_bttn.Size = new System.Drawing.Size(128, 52);
            this.own_factors_bttn.TabIndex = 20;
            this.own_factors_bttn.Text = "Put your own factors ";
            this.own_factors_bttn.UseVisualStyleBackColor = false;
            // 
            // show_factors
            // 
            this.show_factors.BackColor = System.Drawing.Color.Black;
            this.show_factors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.show_factors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_factors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_factors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_factors.Location = new System.Drawing.Point(1466, 151);
            this.show_factors.Name = "show_factors";
            this.show_factors.Size = new System.Drawing.Size(128, 52);
            this.show_factors.TabIndex = 21;
            this.show_factors.Text = "Show factors";
            this.show_factors.UseVisualStyleBackColor = false;
            this.show_factors.Click += new System.EventHandler(this.show_factors_Click);
            // 
            // put_rate_to_all_factors
            // 
            this.put_rate_to_all_factors.BackColor = System.Drawing.Color.Black;
            this.put_rate_to_all_factors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.put_rate_to_all_factors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.put_rate_to_all_factors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.put_rate_to_all_factors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.put_rate_to_all_factors.Location = new System.Drawing.Point(1466, 274);
            this.put_rate_to_all_factors.Name = "put_rate_to_all_factors";
            this.put_rate_to_all_factors.Size = new System.Drawing.Size(128, 52);
            this.put_rate_to_all_factors.TabIndex = 22;
            this.put_rate_to_all_factors.Text = "Put Rate to all factors";
            this.put_rate_to_all_factors.UseVisualStyleBackColor = false;
            this.put_rate_to_all_factors.Click += new System.EventHandler(this.put_rate_to_all_factors_Click);
            // 
            // panel_factors
            // 
            this.panel_factors.Controls.Add(this.rate_Box_all);
            this.panel_factors.Location = new System.Drawing.Point(1441, 349);
            this.panel_factors.Name = "panel_factors";
            this.panel_factors.Size = new System.Drawing.Size(179, 143);
            this.panel_factors.TabIndex = 23;
            // 
            // rate_Box_all
            // 
            this.rate_Box_all.FormattingEnabled = true;
            this.rate_Box_all.Items.AddRange(new object[] {
            "No InFluence",
            "Incidental",
            "Moderate",
            "Average",
            "Significant",
            "Essential"});
            this.rate_Box_all.Location = new System.Drawing.Point(15, 23);
            this.rate_Box_all.Name = "rate_Box_all";
            this.rate_Box_all.Size = new System.Drawing.Size(155, 21);
            this.rate_Box_all.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1684, 663);
            this.Controls.Add(this.panel_factors);
            this.Controls.Add(this.put_rate_to_all_factors);
            this.Controls.Add(this.show_factors);
            this.Controls.Add(this.own_factors_bttn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.F_CB);
            this.Controls.Add(this.I_CB);
            this.Controls.Add(this.Q_CB);
            this.Controls.Add(this.Output_CB);
            this.Controls.Add(this.Input_CB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UFP_box);
            this.Controls.Add(this.calc_ufp);
            this.Controls.Add(this.EIF_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ILF_box);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.Query_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_box);
            this.Name = "Form1";
            this.Text = "Function Point calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_factors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Query_box;
        private System.Windows.Forms.TextBox output_box;
        private System.Windows.Forms.TextBox ILF_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EIF_box;
        private System.Windows.Forms.Button calc_ufp;
        private System.Windows.Forms.TextBox UFP_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Input_CB;
        private System.Windows.Forms.ComboBox Output_CB;
        private System.Windows.Forms.ComboBox Q_CB;
        private System.Windows.Forms.ComboBox I_CB;
        private System.Windows.Forms.ComboBox F_CB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button own_factors_bttn;
        private System.Windows.Forms.Button show_factors;
        private System.Windows.Forms.Button put_rate_to_all_factors;
        private System.Windows.Forms.Panel panel_factors;
        private System.Windows.Forms.ComboBox rate_Box_all;
    }
}

