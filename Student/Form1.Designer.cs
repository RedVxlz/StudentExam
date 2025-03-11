namespace Student
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
            this.btnShowStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbgrade = new System.Windows.Forms.TextBox();
            this.tbmajor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbadvisor = new System.Windows.Forms.Label();
            this.lbgrade = new System.Windows.Forms.Label();
            this.lbmajor = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxStd = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowGrade = new System.Windows.Forms.Button();
            this.tbAdvisor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowStudent
            // 
            this.btnShowStudent.Location = new System.Drawing.Point(346, 255);
            this.btnShowStudent.Name = "btnShowStudent";
            this.btnShowStudent.Size = new System.Drawing.Size(173, 53);
            this.btnShowStudent.TabIndex = 1;
            this.btnShowStudent.Text = "แสดงข้อมูลนักศึกษา";
            this.btnShowStudent.UseVisualStyleBackColor = true;
            this.btnShowStudent.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(66, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "รหัสนักศึกษา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(66, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "สาขา";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(66, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "เกรด";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(66, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "อาจารย์ที่ปรึกษา";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(154, 75);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(121, 20);
            this.tbid.TabIndex = 7;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(154, 46);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(121, 20);
            this.tbname.TabIndex = 8;
            // 
            // tbgrade
            // 
            this.tbgrade.Location = new System.Drawing.Point(154, 133);
            this.tbgrade.Name = "tbgrade";
            this.tbgrade.Size = new System.Drawing.Size(121, 20);
            this.tbgrade.TabIndex = 9;
            // 
            // tbmajor
            // 
            this.tbmajor.Location = new System.Drawing.Point(154, 103);
            this.tbmajor.Name = "tbmajor";
            this.tbmajor.Size = new System.Drawing.Size(121, 20);
            this.tbmajor.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lbadvisor);
            this.groupBox1.Controls.Add(this.lbgrade);
            this.groupBox1.Controls.Add(this.lbmajor);
            this.groupBox1.Controls.Add(this.lbid);
            this.groupBox1.Controls.Add(this.lbname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(346, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 194);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลนักศึกษา";
            // 
            // lbadvisor
            // 
            this.lbadvisor.AutoSize = true;
            this.lbadvisor.Location = new System.Drawing.Point(145, 155);
            this.lbadvisor.Name = "lbadvisor";
            this.lbadvisor.Size = new System.Drawing.Size(0, 13);
            this.lbadvisor.TabIndex = 22;
            // 
            // lbgrade
            // 
            this.lbgrade.AutoSize = true;
            this.lbgrade.Location = new System.Drawing.Point(145, 121);
            this.lbgrade.Name = "lbgrade";
            this.lbgrade.Size = new System.Drawing.Size(0, 13);
            this.lbgrade.TabIndex = 21;
            // 
            // lbmajor
            // 
            this.lbmajor.AutoSize = true;
            this.lbmajor.Location = new System.Drawing.Point(145, 90);
            this.lbmajor.Name = "lbmajor";
            this.lbmajor.Size = new System.Drawing.Size(0, 13);
            this.lbmajor.TabIndex = 20;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(145, 60);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(0, 13);
            this.lbid.TabIndex = 19;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(145, 32);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(0, 13);
            this.lbname.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "อาจารย์ที่ปรึกษา";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ชื่อ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "รหัสนักศึกษา";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "สาขา";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "เกรด";
            // 
            // listBoxStd
            // 
            this.listBoxStd.FormattingEnabled = true;
            this.listBoxStd.Location = new System.Drawing.Point(69, 275);
            this.listBoxStd.Name = "listBoxStd";
            this.listBoxStd.Size = new System.Drawing.Size(206, 108);
            this.listBoxStd.TabIndex = 14;
            this.listBoxStd.SelectedIndexChanged += new System.EventHandler(this.listBoxStd_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(69, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 51);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowGrade
            // 
            this.btnShowGrade.Location = new System.Drawing.Point(346, 314);
            this.btnShowGrade.Name = "btnShowGrade";
            this.btnShowGrade.Size = new System.Drawing.Size(173, 57);
            this.btnShowGrade.TabIndex = 16;
            this.btnShowGrade.Text = "นักศึกษาที่เกรดสูงสุด";
            this.btnShowGrade.UseVisualStyleBackColor = true;
            this.btnShowGrade.Click += new System.EventHandler(this.btnShowGrade_Click);
            // 
            // tbAdvisor
            // 
            this.tbAdvisor.Location = new System.Drawing.Point(154, 164);
            this.tbAdvisor.Name = "tbAdvisor";
            this.tbAdvisor.Size = new System.Drawing.Size(121, 20);
            this.tbAdvisor.TabIndex = 17;
            this.tbAdvisor.TextChanged += new System.EventHandler(this.tbAdvisor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Student.Properties.Resources.vecteezy_flat_design_abstract_background_soft_liquid_shapes_template_;
            this.ClientSize = new System.Drawing.Size(760, 458);
            this.Controls.Add(this.tbAdvisor);
            this.Controls.Add(this.btnShowGrade);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBoxStd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbmajor);
            this.Controls.Add(this.tbgrade);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbgrade;
        private System.Windows.Forms.TextBox tbmajor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbadvisor;
        private System.Windows.Forms.Label lbgrade;
        private System.Windows.Forms.Label lbmajor;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxStd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowGrade;
        private System.Windows.Forms.TextBox tbAdvisor;
    }
}

