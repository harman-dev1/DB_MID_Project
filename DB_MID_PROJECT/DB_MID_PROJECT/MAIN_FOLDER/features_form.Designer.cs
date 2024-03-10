namespace DB_MID_PROJECT.MAIN_FOLDER
{
    partial class features_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.evaluationbutton = new System.Windows.Forms.Button();
            this.projectbutton = new System.Windows.Forms.Button();
            this.groupbutton = new System.Windows.Forms.Button();
            this.advisorbutton = new System.Windows.Forms.Button();
            this.studentbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 450);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(620, 236);
            this.dataGridView1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.46572F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.53428F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(185, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(620, 149);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(458, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save As PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "List of projects along with advisory board and list of students",
            "Select advisors and the projects they are supervising",
            "Select groups and their projects with the assigned dates"});
            this.comboBox1.Location = new System.Drawing.Point(6, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(185, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 61);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Final YEAR PROJECT";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.evaluationbutton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.projectbutton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupbutton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.advisorbutton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.studentbutton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.34884F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.65116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(185, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // evaluationbutton
            // 
            this.evaluationbutton.BackColor = System.Drawing.Color.Black;
            this.evaluationbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evaluationbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluationbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.evaluationbutton.Location = new System.Drawing.Point(6, 359);
            this.evaluationbutton.Name = "evaluationbutton";
            this.evaluationbutton.Size = new System.Drawing.Size(173, 85);
            this.evaluationbutton.TabIndex = 9;
            this.evaluationbutton.Text = "Evaluation";
            this.evaluationbutton.UseVisualStyleBackColor = false;
            this.evaluationbutton.Click += new System.EventHandler(this.evaluationbutton_Click);
            this.evaluationbutton.MouseLeave += new System.EventHandler(this.evaluationbutton_MouseLeave);
            this.evaluationbutton.MouseHover += new System.EventHandler(this.evaluationbutton_MouseHover);
            // 
            // projectbutton
            // 
            this.projectbutton.BackColor = System.Drawing.Color.Black;
            this.projectbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.projectbutton.Location = new System.Drawing.Point(6, 261);
            this.projectbutton.Name = "projectbutton";
            this.projectbutton.Size = new System.Drawing.Size(173, 89);
            this.projectbutton.TabIndex = 8;
            this.projectbutton.Text = "Project";
            this.projectbutton.UseVisualStyleBackColor = false;
            this.projectbutton.Click += new System.EventHandler(this.projectbutton_Click);
            this.projectbutton.MouseLeave += new System.EventHandler(this.projectbutton_MouseLeave_1);
            this.projectbutton.MouseHover += new System.EventHandler(this.projectbutton_MouseHover_1);
            // 
            // groupbutton
            // 
            this.groupbutton.BackColor = System.Drawing.Color.Black;
            this.groupbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.groupbutton.Location = new System.Drawing.Point(6, 158);
            this.groupbutton.Name = "groupbutton";
            this.groupbutton.Size = new System.Drawing.Size(173, 94);
            this.groupbutton.TabIndex = 7;
            this.groupbutton.Text = "Group";
            this.groupbutton.UseVisualStyleBackColor = false;
            this.groupbutton.Click += new System.EventHandler(this.groupbutton_Click);
            this.groupbutton.MouseLeave += new System.EventHandler(this.groupbutton_MouseLeave_1);
            this.groupbutton.MouseHover += new System.EventHandler(this.groupbutton_MouseHover_1);
            // 
            // advisorbutton
            // 
            this.advisorbutton.BackColor = System.Drawing.Color.Black;
            this.advisorbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advisorbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisorbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.advisorbutton.Location = new System.Drawing.Point(6, 75);
            this.advisorbutton.Name = "advisorbutton";
            this.advisorbutton.Size = new System.Drawing.Size(173, 74);
            this.advisorbutton.TabIndex = 6;
            this.advisorbutton.Text = "Advisor";
            this.advisorbutton.UseVisualStyleBackColor = false;
            this.advisorbutton.Click += new System.EventHandler(this.advisorbutton_Click);
            this.advisorbutton.MouseLeave += new System.EventHandler(this.advisorbutton_MouseLeave_1);
            this.advisorbutton.MouseHover += new System.EventHandler(this.advisorbutton_MouseHover_1);
            // 
            // studentbutton
            // 
            this.studentbutton.BackColor = System.Drawing.Color.Black;
            this.studentbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.studentbutton.Location = new System.Drawing.Point(6, 6);
            this.studentbutton.Name = "studentbutton";
            this.studentbutton.Size = new System.Drawing.Size(173, 60);
            this.studentbutton.TabIndex = 5;
            this.studentbutton.Text = "Student";
            this.studentbutton.UseVisualStyleBackColor = false;
            this.studentbutton.Click += new System.EventHandler(this.studentbutton_Click);
            this.studentbutton.MouseLeave += new System.EventHandler(this.studentbutton_MouseLeave_1);
            this.studentbutton.MouseHover += new System.EventHandler(this.studentbutton_MouseHover_1);
            // 
            // features_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "features_form";
            this.Text = "features_form";
            this.Load += new System.EventHandler(this.features_form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button studentbutton;
        private System.Windows.Forms.Button evaluationbutton;
        private System.Windows.Forms.Button projectbutton;
        private System.Windows.Forms.Button groupbutton;
        private System.Windows.Forms.Button advisorbutton;
    }
}