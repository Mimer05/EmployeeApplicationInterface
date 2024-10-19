namespace EmployeeApplicationInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TBFirstName = new TextBox();
            TBLastName = new TextBox();
            TBDepartment = new TextBox();
            TBJobTitle = new TextBox();
            TBRatePerHour = new TextBox();
            TBTotalHoursWorked = new TextBox();
            BSalary = new Button();
            LBFirstName = new Label();
            LBLastName = new Label();
            LBSalary = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 29);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(339, 29);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 116);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 2;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(339, 116);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 3;
            label4.Text = "Job title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 216);
            label5.Name = "label5";
            label5.Size = new Size(99, 18);
            label5.TabIndex = 4;
            label5.Text = "Rate per hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(309, 216);
            label6.Name = "label6";
            label6.Size = new Size(142, 18);
            label6.TabIndex = 5;
            label6.Text = "Total hours worked ";
            // 
            // TBFirstName
            // 
            TBFirstName.BackColor = SystemColors.InactiveBorder;
            TBFirstName.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBFirstName.Location = new Point(54, 67);
            TBFirstName.Name = "TBFirstName";
            TBFirstName.Size = new Size(172, 23);
            TBFirstName.TabIndex = 6;
            // 
            // TBLastName
            // 
            TBLastName.BackColor = SystemColors.InactiveBorder;
            TBLastName.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBLastName.Location = new Point(298, 67);
            TBLastName.Name = "TBLastName";
            TBLastName.Size = new Size(172, 23);
            TBLastName.TabIndex = 7;
            // 
            // TBDepartment
            // 
            TBDepartment.BackColor = SystemColors.InactiveBorder;
            TBDepartment.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBDepartment.Location = new Point(54, 143);
            TBDepartment.Name = "TBDepartment";
            TBDepartment.Size = new Size(172, 23);
            TBDepartment.TabIndex = 8;
            // 
            // TBJobTitle
            // 
            TBJobTitle.BackColor = SystemColors.InactiveBorder;
            TBJobTitle.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBJobTitle.Location = new Point(298, 143);
            TBJobTitle.Name = "TBJobTitle";
            TBJobTitle.Size = new Size(172, 23);
            TBJobTitle.TabIndex = 9;
            // 
            // TBRatePerHour
            // 
            TBRatePerHour.BackColor = SystemColors.InactiveBorder;
            TBRatePerHour.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBRatePerHour.Location = new Point(54, 240);
            TBRatePerHour.Name = "TBRatePerHour";
            TBRatePerHour.Size = new Size(172, 23);
            TBRatePerHour.TabIndex = 10;
            // 
            // TBTotalHoursWorked
            // 
            TBTotalHoursWorked.BackColor = SystemColors.InactiveBorder;
            TBTotalHoursWorked.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBTotalHoursWorked.Location = new Point(298, 240);
            TBTotalHoursWorked.Name = "TBTotalHoursWorked";
            TBTotalHoursWorked.Size = new Size(172, 23);
            TBTotalHoursWorked.TabIndex = 11;
            // 
            // BSalary
            // 
            BSalary.BackColor = Color.Lavender;
            BSalary.Font = new Font("Californian FB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BSalary.Location = new Point(190, 288);
            BSalary.Name = "BSalary";
            BSalary.Size = new Size(138, 39);
            BSalary.TabIndex = 12;
            BSalary.Text = "Compute Salary";
            BSalary.UseVisualStyleBackColor = false;
            BSalary.Click += BSalary_Click;
            // 
            // LBFirstName
            // 
            LBFirstName.AutoSize = true;
            LBFirstName.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBFirstName.Location = new Point(54, 350);
            LBFirstName.Name = "LBFirstName";
            LBFirstName.Size = new Size(206, 18);
            LBFirstName.TabIndex = 13;
            LBFirstName.Text = "First Name: <First name here>";
            LBFirstName.Click += label7_Click;
            // 
            // LBLastName
            // 
            LBLastName.AutoSize = true;
            LBLastName.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLastName.Location = new Point(54, 397);
            LBLastName.Name = "LBLastName";
            LBLastName.Size = new Size(198, 18);
            LBLastName.TabIndex = 14;
            LBLastName.Text = "Last Name: <Last name here>";
            // 
            // LBSalary
            // 
            LBSalary.AutoSize = true;
            LBSalary.Font = new Font("Californian FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBSalary.Location = new Point(54, 440);
            LBSalary.Name = "LBSalary";
            LBSalary.Size = new Size(125, 18);
            LBSalary.TabIndex = 15;
            LBSalary.Text = "Basic salary: 00.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(574, 488);
            Controls.Add(LBSalary);
            Controls.Add(LBLastName);
            Controls.Add(LBFirstName);
            Controls.Add(BSalary);
            Controls.Add(TBTotalHoursWorked);
            Controls.Add(TBRatePerHour);
            Controls.Add(TBJobTitle);
            Controls.Add(TBDepartment);
            Controls.Add(TBLastName);
            Controls.Add(TBFirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Highlight;
            Name = "Form1";
            Text = "Employee Salary Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TBFirstName;
        private TextBox TBLastName;
        private TextBox TBDepartment;
        private TextBox TBJobTitle;
        private TextBox TBRatePerHour;
        private TextBox TBTotalHoursWorked;
        private Button BSalary;
        private Label LBFirstName;
        private Label LBLastName;
        private Label LBSalary;
    }
}
