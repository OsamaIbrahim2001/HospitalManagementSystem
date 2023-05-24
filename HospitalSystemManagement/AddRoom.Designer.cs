using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystemManagement
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            panel1 = new Panel();
            lblClose = new Label();
            label1 = new Label();
            label3 = new Label();
            btnSaveFllower = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 173, 193);
            panel1.Controls.Add(lblClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 45);
            panel1.TabIndex = 16;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblClose.ForeColor = SystemColors.ControlDarkDark;
            lblClose.Location = new Point(521, 10);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(23, 25);
            lblClose.TabIndex = 1;
            lblClose.Text = "x";
            lblClose.TextAlign = ContentAlignment.MiddleCenter;
           // lblClose.Click += lblClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 173, 193);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 0;
            label1.Text = "     Room";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 195);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 21;
            label3.Text = "Department";
            // 
            // btnSaveFllower
            // 
            btnSaveFllower.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSaveFllower.BackColor = SystemColors.Window;
            btnSaveFllower.FlatAppearance.BorderSize = 2;
            btnSaveFllower.FlatStyle = FlatStyle.Flat;
            btnSaveFllower.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveFllower.ForeColor = Color.FromArgb(90, 149, 153);
            btnSaveFllower.Location = new Point(189, 322);
            btnSaveFllower.Name = "btnSaveFllower";
            btnSaveFllower.Size = new Size(161, 54);
            btnSaveFllower.TabIndex = 19;
            btnSaveFllower.Text = "Save";
            btnSaveFllower.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 101);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 18;
            label2.Text = "Location";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(477, 33);
            comboBox1.TabIndex = 25;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(36, 145);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(477, 33);
            comboBox2.TabIndex = 26;
            // 
            // AddRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(546, 411);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(btnSaveFllower);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSaveFllower;
    }
}