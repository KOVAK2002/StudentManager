namespace StudentManager
{
    partial class Add_Student_Form
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
            lbName = new Label();
            lbLast_Name = new Label();
            lbBirth = new Label();
            lbGender = new Label();
            lbPhone = new Label();
            lbAddr = new Label();
            lbPicture = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            pictureBox1 = new PictureBox();
            btnAddPict = new Button();
            btnAdd = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(18, 30);
            lbName.Name = "lbName";
            lbName.Size = new Size(147, 35);
            lbName.TabIndex = 0;
            lbName.Text = "First Name :";
            // 
            // lbLast_Name
            // 
            lbLast_Name.AutoSize = true;
            lbLast_Name.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbLast_Name.Location = new Point(20, 81);
            lbLast_Name.Name = "lbLast_Name";
            lbLast_Name.Size = new Size(145, 35);
            lbLast_Name.TabIndex = 1;
            lbLast_Name.Text = "Last Name :";
            // 
            // lbBirth
            // 
            lbBirth.AutoSize = true;
            lbBirth.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbBirth.Location = new Point(87, 133);
            lbBirth.Name = "lbBirth";
            lbBirth.Size = new Size(78, 35);
            lbBirth.TabIndex = 2;
            lbBirth.Text = "Birth :";
            lbBirth.Click += lbBirth_Click;
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbGender.Location = new Point(57, 182);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(108, 35);
            lbGender.TabIndex = 3;
            lbGender.Text = "Gender :";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbPhone.Location = new Point(68, 229);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(97, 35);
            lbPhone.TabIndex = 4;
            lbPhone.Text = "Phone :";
            // 
            // lbAddr
            // 
            lbAddr.AutoSize = true;
            lbAddr.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbAddr.Location = new Point(48, 279);
            lbAddr.Name = "lbAddr";
            lbAddr.Size = new Size(117, 35);
            lbAddr.TabIndex = 5;
            lbAddr.Text = "Address :";
            // 
            // lbPicture
            // 
            lbPicture.AutoSize = true;
            lbPicture.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbPicture.Location = new Point(68, 408);
            lbPicture.Name = "lbPicture";
            lbPicture.Size = new Size(91, 35);
            lbPicture.TabIndex = 6;
            lbPicture.Text = "Picture";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 27);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(203, 238);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(203, 288);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 92);
            textBox4.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(202, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbMale.Location = new Point(229, 185);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(76, 32);
            rbMale.TabIndex = 12;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbFemale.Location = new Point(339, 185);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(95, 32);
            rbFemale.TabIndex = 13;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(203, 408);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 200);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnAddPict
            // 
            btnAddPict.Location = new Point(202, 625);
            btnAddPict.Name = "btnAddPict";
            btnAddPict.Size = new Size(250, 31);
            btnAddPict.TabIndex = 15;
            btnAddPict.Text = "Add picture";
            btnAddPict.UseVisualStyleBackColor = true;
            btnAddPict.Click += btnAddPict_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(403, 696);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 56);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(172, 696);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 56);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Add_Student_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(619, 787);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(btnAddPict);
            Controls.Add(pictureBox1);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbPicture);
            Controls.Add(lbAddr);
            Controls.Add(lbPhone);
            Controls.Add(lbGender);
            Controls.Add(lbBirth);
            Controls.Add(lbLast_Name);
            Controls.Add(lbName);
            Name = "Add_Student_Form";
            Text = "Add_Student_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbLast_Name;
        private Label lbBirth;
        private Label lbGender;
        private Label lbPhone;
        private Label lbAddr;
        private Label lbPicture;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private PictureBox pictureBox1;
        private Button btnAddPict;
        private Button btnAdd;
        private Button btnCancel;
    }
}