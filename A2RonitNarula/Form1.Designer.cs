namespace A2RonitNarula
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
            this.grpEmployeeType = new System.Windows.Forms.GroupBox();
            this.rdoWeeklySalary = new System.Windows.Forms.RadioButton();
            this.rdoCommissionBased = new System.Windows.Forms.RadioButton();
            this.rdoHourlyPaid = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNetEarnings = new System.Windows.Forms.TextBox();
            this.txtLessTax = new System.Windows.Forms.TextBox();
            this.txtGrossEarnings = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpEmployeeType.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeType
            // 
            this.grpEmployeeType.Controls.Add(this.rdoWeeklySalary);
            this.grpEmployeeType.Controls.Add(this.rdoCommissionBased);
            this.grpEmployeeType.Controls.Add(this.rdoHourlyPaid);
            this.grpEmployeeType.Location = new System.Drawing.Point(22, 12);
            this.grpEmployeeType.Name = "grpEmployeeType";
            this.grpEmployeeType.Size = new System.Drawing.Size(529, 83);
            this.grpEmployeeType.TabIndex = 0;
            this.grpEmployeeType.TabStop = false;
            this.grpEmployeeType.Text = "Select type of employee";
            this.grpEmployeeType.Enter += new System.EventHandler(this.GrpEmployeeType_Enter);
            // 
            // rdoWeeklySalary
            // 
            this.rdoWeeklySalary.AutoSize = true;
            this.rdoWeeklySalary.Location = new System.Drawing.Point(386, 33);
            this.rdoWeeklySalary.Name = "rdoWeeklySalary";
            this.rdoWeeklySalary.Size = new System.Drawing.Size(119, 21);
            this.rdoWeeklySalary.TabIndex = 2;
            this.rdoWeeklySalary.Text = "Weekly Salary";
            this.rdoWeeklySalary.UseVisualStyleBackColor = true;
            this.rdoWeeklySalary.CheckedChanged += new System.EventHandler(this.RdoWeeklySalary_CheckedChanged);
            // 
            // rdoCommissionBased
            // 
            this.rdoCommissionBased.AutoSize = true;
            this.rdoCommissionBased.Location = new System.Drawing.Point(189, 33);
            this.rdoCommissionBased.Name = "rdoCommissionBased";
            this.rdoCommissionBased.Size = new System.Drawing.Size(148, 21);
            this.rdoCommissionBased.TabIndex = 1;
            this.rdoCommissionBased.Text = "Commission Based";
            this.rdoCommissionBased.UseVisualStyleBackColor = true;
            this.rdoCommissionBased.CheckedChanged += new System.EventHandler(this.RdoCommissionBased_CheckedChanged);
            // 
            // rdoHourlyPaid
            // 
            this.rdoHourlyPaid.AutoSize = true;
            this.rdoHourlyPaid.Checked = true;
            this.rdoHourlyPaid.Location = new System.Drawing.Point(38, 33);
            this.rdoHourlyPaid.Name = "rdoHourlyPaid";
            this.rdoHourlyPaid.Size = new System.Drawing.Size(102, 21);
            this.rdoHourlyPaid.TabIndex = 0;
            this.rdoHourlyPaid.TabStop = true;
            this.rdoHourlyPaid.Text = "Hourly Paid";
            this.rdoHourlyPaid.UseVisualStyleBackColor = true;
            this.rdoHourlyPaid.CheckedChanged += new System.EventHandler(this.RdoHourlyPaid_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(448, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 39);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(448, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(448, 273);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 39);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNetEarnings);
            this.groupBox3.Controls.Add(this.txtLessTax);
            this.groupBox3.Controls.Add(this.txtGrossEarnings);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(22, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 173);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculated wage";
            // 
            // txtNetEarnings
            // 
            this.txtNetEarnings.Location = new System.Drawing.Point(126, 121);
            this.txtNetEarnings.Name = "txtNetEarnings";
            this.txtNetEarnings.ReadOnly = true;
            this.txtNetEarnings.Size = new System.Drawing.Size(379, 22);
            this.txtNetEarnings.TabIndex = 5;
            // 
            // txtLessTax
            // 
            this.txtLessTax.Location = new System.Drawing.Point(126, 80);
            this.txtLessTax.Name = "txtLessTax";
            this.txtLessTax.ReadOnly = true;
            this.txtLessTax.Size = new System.Drawing.Size(379, 22);
            this.txtLessTax.TabIndex = 4;
            // 
            // txtGrossEarnings
            // 
            this.txtGrossEarnings.Location = new System.Drawing.Point(126, 39);
            this.txtGrossEarnings.Name = "txtGrossEarnings";
            this.txtGrossEarnings.ReadOnly = true;
            this.txtGrossEarnings.Size = new System.Drawing.Size(379, 22);
            this.txtGrossEarnings.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Net Earnings:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Less Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gross Earnings:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Employees:";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(148, 538);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(379, 24);
            this.cmbEmployees.TabIndex = 7;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(37, 81);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(103, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Hours Worked:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(38, 117);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(90, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Hourly wage:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(157, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(157, 81);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(211, 22);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(157, 117);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(211, 22);
            this.txt2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt2);
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(22, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 188);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input the employee\'s information";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(583, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpEmployeeType);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEmployeeType.ResumeLayout(false);
            this.grpEmployeeType.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeType;
        private System.Windows.Forms.RadioButton rdoWeeklySalary;
        private System.Windows.Forms.RadioButton rdoCommissionBased;
        private System.Windows.Forms.RadioButton rdoHourlyPaid;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNetEarnings;
        private System.Windows.Forms.TextBox txtLessTax;
        private System.Windows.Forms.TextBox txtGrossEarnings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

