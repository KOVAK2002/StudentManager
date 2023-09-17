namespace StudentManager
{
    partial class UpdateDeleteStudentForm
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
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lbBirth = new Label();
            lbLast_Name = new Label();
            lbName = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(344, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(345, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 27);
            textBox1.TabIndex = 15;
            // 
            // lbBirth
            // 
            lbBirth.AutoSize = true;
            lbBirth.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbBirth.Location = new Point(229, 203);
            lbBirth.Name = "lbBirth";
            lbBirth.Size = new Size(78, 35);
            lbBirth.TabIndex = 14;
            lbBirth.Text = "Birth :";
            // 
            // lbLast_Name
            // 
            lbLast_Name.AutoSize = true;
            lbLast_Name.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbLast_Name.Location = new Point(162, 151);
            lbLast_Name.Name = "lbLast_Name";
            lbLast_Name.Size = new Size(145, 35);
            lbLast_Name.TabIndex = 13;
            lbLast_Name.Text = "Last Name :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(160, 100);
            lbName.Name = "lbName";
            lbName.Size = new Size(147, 35);
            lbName.TabIndex = 12;
            lbName.Text = "First Name :";
            // 
            // UpdateDeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbBirth);
            Controls.Add(lbLast_Name);
            Controls.Add(lbName);
            Name = "UpdateDeleteStudentForm";
            Text = "UpdateDeleteStudentForm";
            Load += UpdateDeleteStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lbBirth;
        private Label lbLast_Name;
        private Label lbName;
    }
}