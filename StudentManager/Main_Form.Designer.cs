namespace StudentManager
{
    partial class Main_Form
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
            menuStrip1 = new MenuStrip();
            sTUDENTToolStripMenuItem = new ToolStripMenuItem();
            cOURSEToolStripMenuItem = new ToolStripMenuItem();
            sCOREToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentToolStripMenuItem = new ToolStripMenuItem();
            editRemoveToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sTUDENTToolStripMenuItem, cOURSEToolStripMenuItem, sCOREToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 43);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            sTUDENTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewStudentToolStripMenuItem, editRemoveToolStripMenuItem, printToolStripMenuItem });
            sTUDENTToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            sTUDENTToolStripMenuItem.Size = new Size(135, 39);
            sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // cOURSEToolStripMenuItem
            // 
            cOURSEToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            cOURSEToolStripMenuItem.Size = new Size(120, 39);
            cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // sCOREToolStripMenuItem
            // 
            sCOREToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            sCOREToolStripMenuItem.Size = new Size(103, 39);
            sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // addNewStudentToolStripMenuItem
            // 
            addNewStudentToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            addNewStudentToolStripMenuItem.Size = new Size(292, 40);
            addNewStudentToolStripMenuItem.Text = "Add new student";
            addNewStudentToolStripMenuItem.Click += addNewStudentToolStripMenuItem_Click;
            // 
            // editRemoveToolStripMenuItem
            // 
            editRemoveToolStripMenuItem.BackColor = SystemColors.ActiveBorder;
            editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            editRemoveToolStripMenuItem.Size = new Size(292, 40);
            editRemoveToolStripMenuItem.Text = "Edit / remove";
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(292, 40);
            printToolStripMenuItem.Text = "Print";
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main_Form";
            Text = "Main_Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sTUDENTToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripMenuItem editRemoveToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem cOURSEToolStripMenuItem;
        private ToolStripMenuItem sCOREToolStripMenuItem;
    }
}