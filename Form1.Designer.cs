namespace Lab5_EmployeePayroll
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
            this.rbSalary = new System.Windows.Forms.RadioButton();
            this.rbHourly = new System.Windows.Forms.RadioButton();
            this.rbCommission = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbSSN = new System.Windows.Forms.TextBox();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbSSN = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmployeeListbox = new System.Windows.Forms.ListBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.lbAlerts = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSalary
            // 
            this.rbSalary.AutoSize = true;
            this.rbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSalary.Location = new System.Drawing.Point(42, 47);
            this.rbSalary.Name = "rbSalary";
            this.rbSalary.Size = new System.Drawing.Size(122, 35);
            this.rbSalary.TabIndex = 0;
            this.rbSalary.TabStop = true;
            this.rbSalary.Text = "Salary";
            this.rbSalary.UseVisualStyleBackColor = true;
            this.rbSalary.CheckedChanged += new System.EventHandler(this.rbSalary_CheckedChanged);
            // 
            // rbHourly
            // 
            this.rbHourly.AutoSize = true;
            this.rbHourly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHourly.Location = new System.Drawing.Point(195, 47);
            this.rbHourly.Name = "rbHourly";
            this.rbHourly.Size = new System.Drawing.Size(124, 35);
            this.rbHourly.TabIndex = 1;
            this.rbHourly.TabStop = true;
            this.rbHourly.Text = "Hourly";
            this.rbHourly.UseVisualStyleBackColor = true;
            this.rbHourly.CheckedChanged += new System.EventHandler(this.rbHourly_CheckedChanged);
            // 
            // rbCommission
            // 
            this.rbCommission.AutoSize = true;
            this.rbCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCommission.Location = new System.Drawing.Point(350, 47);
            this.rbCommission.Name = "rbCommission";
            this.rbCommission.Size = new System.Drawing.Size(194, 35);
            this.rbCommission.TabIndex = 2;
            this.rbCommission.TabStop = true;
            this.rbCommission.Text = "Commission";
            this.rbCommission.UseVisualStyleBackColor = true;
            this.rbCommission.CheckedChanged += new System.EventHandler(this.rbCommission_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCommission);
            this.groupBox1.Controls.Add(this.rbHourly);
            this.groupBox1.Controls.Add(this.rbSalary);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(648, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Type:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(234, 59);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(507, 44);
            this.tbFirstName.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(234, 124);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(507, 44);
            this.tbLastName.TabIndex = 5;
            // 
            // tbSSN
            // 
            this.tbSSN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSSN.Location = new System.Drawing.Point(234, 194);
            this.tbSSN.Name = "tbSSN";
            this.tbSSN.Size = new System.Drawing.Size(507, 44);
            this.tbSSN.TabIndex = 6;
            // 
            // tbRate
            // 
            this.tbRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRate.Location = new System.Drawing.Point(234, 266);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(507, 44);
            this.tbRate.TabIndex = 7;
            // 
            // tbHours
            // 
            this.tbHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHours.Location = new System.Drawing.Point(234, 335);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(507, 44);
            this.tbHours.TabIndex = 8;
            // 
            // lbFirstName
            // 
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(23, 59);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(205, 37);
            this.lbFirstName.TabIndex = 9;
            this.lbFirstName.Text = "First Name:";
            // 
            // lbLastName
            // 
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(21, 124);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(207, 44);
            this.lbLastName.TabIndex = 10;
            this.lbLastName.Text = "Last Name:";
            // 
            // lbSSN
            // 
            this.lbSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSN.Location = new System.Drawing.Point(21, 194);
            this.lbSSN.Name = "lbSSN";
            this.lbSSN.Size = new System.Drawing.Size(207, 44);
            this.lbSSN.TabIndex = 11;
            this.lbSSN.Text = "SSN:";
            // 
            // lbRate
            // 
            this.lbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRate.Location = new System.Drawing.Point(17, 266);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(211, 44);
            this.lbRate.TabIndex = 12;
            this.lbRate.Text = "Weekly Salary:";
            // 
            // lbHours
            // 
            this.lbHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.Location = new System.Drawing.Point(23, 335);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(205, 44);
            this.lbHours.TabIndex = 13;
            this.lbHours.Text = "Hours:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbHours);
            this.groupBox2.Controls.Add(this.lbRate);
            this.groupBox2.Controls.Add(this.lbSSN);
            this.groupBox2.Controls.Add(this.lbLastName);
            this.groupBox2.Controls.Add(this.lbFirstName);
            this.groupBox2.Controls.Add(this.tbHours);
            this.groupBox2.Controls.Add(this.tbRate);
            this.groupBox2.Controls.Add(this.tbSSN);
            this.groupBox2.Controls.Add(this.tbLastName);
            this.groupBox2.Controls.Add(this.tbFirstName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(525, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 435);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Information";
            // 
            // EmployeeListbox
            // 
            this.EmployeeListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListbox.FormattingEnabled = true;
            this.EmployeeListbox.HorizontalScrollbar = true;
            this.EmployeeListbox.ItemHeight = 31;
            this.EmployeeListbox.Location = new System.Drawing.Point(19, 85);
            this.EmployeeListbox.Name = "EmployeeListbox";
            this.EmployeeListbox.Size = new System.Drawing.Size(476, 562);
            this.EmployeeListbox.TabIndex = 15;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(611, 685);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(142, 60);
            this.submitBtn.TabIndex = 16;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // lbAlerts
            // 
            this.lbAlerts.AutoSize = true;
            this.lbAlerts.Location = new System.Drawing.Point(792, 685);
            this.lbAlerts.Name = "lbAlerts";
            this.lbAlerts.Size = new System.Drawing.Size(73, 25);
            this.lbAlerts.TabIndex = 17;
            this.lbAlerts.Text = "Alerts:";
            this.lbAlerts.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 949);
            this.Controls.Add(this.lbAlerts);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.EmployeeListbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSalary;
        private System.Windows.Forms.RadioButton rbHourly;
        private System.Windows.Forms.RadioButton rbCommission;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbSSN;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbSSN;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox EmployeeListbox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label lbAlerts;
    }
}

