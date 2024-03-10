namespace DB_MID_PROJECT.MANAGE_Students
{
    partial class delete_student_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.student_person_grid_view = new System.Windows.Forms.DataGridView();
            this.registeration_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.student_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.student_person_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Students";
            // 
            // student_person_grid_view
            // 
            this.student_person_grid_view.AllowUserToDeleteRows = false;
            this.student_person_grid_view.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.student_person_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_person_grid_view.Location = new System.Drawing.Point(12, 222);
            this.student_person_grid_view.Name = "student_person_grid_view";
            this.student_person_grid_view.ReadOnly = true;
            this.student_person_grid_view.Size = new System.Drawing.Size(784, 359);
            this.student_person_grid_view.TabIndex = 3;
            // 
            // registeration_textBox
            // 
            this.registeration_textBox.ForeColor = System.Drawing.Color.Silver;
            this.registeration_textBox.Location = new System.Drawing.Point(238, 77);
            this.registeration_textBox.Name = "registeration_textBox";
            this.registeration_textBox.Size = new System.Drawing.Size(163, 20);
            this.registeration_textBox.TabIndex = 5;
            this.registeration_textBox.Text = "Enter Reg No For Deletion";
            this.registeration_textBox.Enter += new System.EventHandler(this.registeration_textBox_Enter);
            this.registeration_textBox.Leave += new System.EventHandler(this.registeration_textBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(66, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registeration No";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(508, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(508, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Show Person";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // student_button
            // 
            this.student_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.student_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_button.Location = new System.Drawing.Point(141, 154);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(131, 40);
            this.student_button.TabIndex = 7;
            this.student_button.Text = "Show Student";
            this.student_button.UseVisualStyleBackColor = false;
            this.student_button.Click += new System.EventHandler(this.student_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(342, 603);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = " <<<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(683, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 47);
            this.button4.TabIndex = 10;
            this.button4.Text = "Delete Person";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // delete_student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(813, 655);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.student_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registeration_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.student_person_grid_view);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_student_form";
            this.Text = "delete_student_form";
            this.Load += new System.EventHandler(this.delete_student_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_person_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView student_person_grid_view;
        private System.Windows.Forms.TextBox registeration_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button student_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}