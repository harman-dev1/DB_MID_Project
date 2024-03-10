namespace DB_MID_PROJECT.MANAGE_Students
{
    partial class edit_student_form
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
            this.label4 = new System.Windows.Forms.Label();
            this.gender_txt_box = new System.Windows.Forms.TextBox();
            this.d_of_birth = new System.Windows.Forms.DateTimePicker();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.last_name_textBox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.contact_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registeration_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.student_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.student_person_grid_view = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.student_person_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(309, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Manage Students";
            // 
            // gender_txt_box
            // 
            this.gender_txt_box.Location = new System.Drawing.Point(184, 251);
            this.gender_txt_box.Name = "gender_txt_box";
            this.gender_txt_box.Size = new System.Drawing.Size(163, 20);
            this.gender_txt_box.TabIndex = 41;
            this.gender_txt_box.Text = "Enter Updated Gender";
            this.gender_txt_box.Enter += new System.EventHandler(this.gender_txt_box_Enter);
            this.gender_txt_box.Leave += new System.EventHandler(this.gender_txt_box_Leave);
            // 
            // d_of_birth
            // 
            this.d_of_birth.Location = new System.Drawing.Point(599, 189);
            this.d_of_birth.Name = "d_of_birth";
            this.d_of_birth.Size = new System.Drawing.Size(200, 20);
            this.d_of_birth.TabIndex = 40;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(184, 185);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(163, 20);
            this.email_textBox.TabIndex = 39;
            this.email_textBox.Text = "Enter Updated Email";
            this.email_textBox.Enter += new System.EventHandler(this.email_textBox_Enter);
            this.email_textBox.Leave += new System.EventHandler(this.email_textBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(446, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Date OF Birth";
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.first_name_textBox.Location = new System.Drawing.Point(184, 61);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(163, 20);
            this.first_name_textBox.TabIndex = 35;
            this.first_name_textBox.Text = "Enter Updated First Name";
            this.first_name_textBox.Enter += new System.EventHandler(this.first_name_textBox_Enter);
            this.first_name_textBox.Leave += new System.EventHandler(this.first_name_textBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "FirstName";
            // 
            // last_name_textBox
            // 
            this.last_name_textBox.Location = new System.Drawing.Point(599, 61);
            this.last_name_textBox.Name = "last_name_textBox";
            this.last_name_textBox.Size = new System.Drawing.Size(163, 20);
            this.last_name_textBox.TabIndex = 33;
            this.last_name_textBox.Text = "Enter Updated Last Name";
            this.last_name_textBox.Enter += new System.EventHandler(this.last_name_textBox_Enter);
            this.last_name_textBox.Leave += new System.EventHandler(this.last_name_textBox_Leave);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LastName.Location = new System.Drawing.Point(446, 65);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(77, 16);
            this.LastName.TabIndex = 32;
            this.LastName.Text = "LastName";
            // 
            // contact_textBox
            // 
            this.contact_textBox.Location = new System.Drawing.Point(599, 122);
            this.contact_textBox.Name = "contact_textBox";
            this.contact_textBox.Size = new System.Drawing.Size(163, 20);
            this.contact_textBox.TabIndex = 31;
            this.contact_textBox.Text = "Enter Updated Contact No";
            this.contact_textBox.Enter += new System.EventHandler(this.contact_textBox_Enter);
            this.contact_textBox.Leave += new System.EventHandler(this.contact_textBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(446, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Contact";
            // 
            // registeration_textBox
            // 
            this.registeration_textBox.Location = new System.Drawing.Point(184, 118);
            this.registeration_textBox.Name = "registeration_textBox";
            this.registeration_textBox.Size = new System.Drawing.Size(181, 20);
            this.registeration_textBox.TabIndex = 29;
            this.registeration_textBox.Text = "Enter Reg No whom you wanna edit";
            this.registeration_textBox.Enter += new System.EventHandler(this.registeration_textBox_Enter);
            this.registeration_textBox.Leave += new System.EventHandler(this.registeration_textBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Registeration No";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(621, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 43;
            this.button2.Text = "Show Person";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // student_button
            // 
            this.student_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.student_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_button.Location = new System.Drawing.Point(621, 544);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(131, 40);
            this.student_button.TabIndex = 42;
            this.student_button.Text = "Show Student";
            this.student_button.UseVisualStyleBackColor = false;
            this.student_button.Click += new System.EventHandler(this.student_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.update_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(516, 240);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(131, 40);
            this.update_button.TabIndex = 44;
            this.update_button.Text = " Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // student_person_grid_view
            // 
            this.student_person_grid_view.AllowUserToDeleteRows = false;
            this.student_person_grid_view.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.student_person_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_person_grid_view.Location = new System.Drawing.Point(3, 327);
            this.student_person_grid_view.Name = "student_person_grid_view";
            this.student_person_grid_view.ReadOnly = true;
            this.student_person_grid_view.Size = new System.Drawing.Size(590, 283);
            this.student_person_grid_view.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(338, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 46;
            this.button1.Text = " <<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(808, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.student_person_grid_view);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.student_button);
            this.Controls.Add(this.gender_txt_box);
            this.Controls.Add(this.d_of_birth);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.first_name_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.last_name_textBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.contact_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registeration_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_student_form";
            this.Text = " ";
            this.Load += new System.EventHandler(this.edit_student_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_person_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gender_txt_box;
        private System.Windows.Forms.DateTimePicker d_of_birth;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox last_name_textBox;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox contact_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registeration_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button student_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.DataGridView student_person_grid_view;
        private System.Windows.Forms.Button button1;
    }
}