
namespace DB_MID_PROJECT.MANAGE_Students
{
    partial class add_student_form
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
            this.registeration_textBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.record_button = new System.Windows.Forms.Button();
            this.contact_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.last_name_textBox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.d_of_birth = new System.Windows.Forms.DateTimePicker();
            this.gender_txt_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registeration No";
            // 
            // registeration_textBox
            // 
            this.registeration_textBox.ForeColor = System.Drawing.Color.Silver;
            this.registeration_textBox.Location = new System.Drawing.Point(184, 184);
            this.registeration_textBox.Name = "registeration_textBox";
            this.registeration_textBox.Size = new System.Drawing.Size(163, 20);
            this.registeration_textBox.TabIndex = 3;
            this.registeration_textBox.Text = "Enter Reg NO";
            this.registeration_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.registeration_textBox.Enter += new System.EventHandler(this.registeration_textBox_Enter);
            this.registeration_textBox.Leave += new System.EventHandler(this.registeration_textBox_Leave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Location = new System.Drawing.Point(281, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 49);
            this.button3.TabIndex = 7;
            this.button3.Text = "Back To Manage Students Page";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // record_button
            // 
            this.record_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.record_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record_button.ForeColor = System.Drawing.Color.White;
            this.record_button.Location = new System.Drawing.Point(510, 422);
            this.record_button.Name = "record_button";
            this.record_button.Size = new System.Drawing.Size(148, 42);
            this.record_button.TabIndex = 8;
            this.record_button.Text = "Save Record";
            this.record_button.UseVisualStyleBackColor = false;
            this.record_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // contact_textBox
            // 
            this.contact_textBox.ForeColor = System.Drawing.Color.Silver;
            this.contact_textBox.Location = new System.Drawing.Point(599, 185);
            this.contact_textBox.Name = "contact_textBox";
            this.contact_textBox.Size = new System.Drawing.Size(163, 20);
            this.contact_textBox.TabIndex = 10;
            this.contact_textBox.Text = "Enter Phone No";
            this.contact_textBox.Enter += new System.EventHandler(this.contact_textBox_Enter);
            this.contact_textBox.Leave += new System.EventHandler(this.contact_textBox_textBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contact";
            // 
            // last_name_textBox
            // 
            this.last_name_textBox.ForeColor = System.Drawing.Color.Silver;
            this.last_name_textBox.Location = new System.Drawing.Point(599, 84);
            this.last_name_textBox.Name = "last_name_textBox";
            this.last_name_textBox.Size = new System.Drawing.Size(163, 20);
            this.last_name_textBox.TabIndex = 12;
            this.last_name_textBox.Text = "Enter Last Name";
            this.last_name_textBox.Enter += new System.EventHandler(this.last_name_textBox_Enter);
            this.last_name_textBox.Leave += new System.EventHandler(this.last_name_textBox_Leave);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(446, 88);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(77, 16);
            this.LastName.TabIndex = 11;
            this.LastName.Text = "LastName";
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.ForeColor = System.Drawing.Color.Silver;
            this.first_name_textBox.Location = new System.Drawing.Point(184, 84);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(163, 20);
            this.first_name_textBox.TabIndex = 14;
            this.first_name_textBox.Text = "Enter First Name";
            this.first_name_textBox.Enter += new System.EventHandler(this.first_name_textBox_Enter);
            this.first_name_textBox.Leave += new System.EventHandler(this.first_name_textBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date OF Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gender";
            // 
            // email_textBox
            // 
            this.email_textBox.ForeColor = System.Drawing.Color.Silver;
            this.email_textBox.Location = new System.Drawing.Point(184, 277);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(163, 20);
            this.email_textBox.TabIndex = 20;
            this.email_textBox.Text = "Enter Email";
            this.email_textBox.Enter += new System.EventHandler(this.email_textBox_Enter);
            this.email_textBox.Leave += new System.EventHandler(this.email_textBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email";
            // 
            // d_of_birth
            // 
            this.d_of_birth.Location = new System.Drawing.Point(599, 277);
            this.d_of_birth.Name = "d_of_birth";
            this.d_of_birth.Size = new System.Drawing.Size(200, 20);
            this.d_of_birth.TabIndex = 23;
            // 
            // gender_txt_box
            // 
            this.gender_txt_box.ForeColor = System.Drawing.Color.Silver;
            this.gender_txt_box.Location = new System.Drawing.Point(184, 371);
            this.gender_txt_box.Name = "gender_txt_box";
            this.gender_txt_box.Size = new System.Drawing.Size(173, 20);
            this.gender_txt_box.TabIndex = 24;
            this.gender_txt_box.Text = "Enter 1 for Male and 2 for Female";
            this.gender_txt_box.Enter += new System.EventHandler(this.gender_txt_box_Enter);
            this.gender_txt_box.Leave += new System.EventHandler(this.gender_txt_box_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(276, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Manage Students";
            // 
            // add_student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.record_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.registeration_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_student_form";
            this.Text = "add_student_form";
            this.Load += new System.EventHandler(this.add_student_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registeration_textBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button record_button;
        private System.Windows.Forms.TextBox contact_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox last_name_textBox;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker d_of_birth;
        private System.Windows.Forms.TextBox gender_txt_box;
        private System.Windows.Forms.Label label4;
    }
}