using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystemManagement
{
    partial class AddOrEditFloors
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCloaseFllower = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNameOfFloower = new System.Windows.Forms.TextBox();
            this.btnSaveFllower = new System.Windows.Forms.Button();
            this.txtNumOfRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Floor Description";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.lblCloaseFllower);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 39);
            this.panel1.TabIndex = 3;
            // 
            // lblCloaseFllower
            // 
            this.lblCloaseFllower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCloaseFllower.AutoSize = true;
            this.lblCloaseFllower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.lblCloaseFllower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCloaseFllower.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCloaseFllower.ForeColor = System.Drawing.Color.DimGray;
            this.lblCloaseFllower.Location = new System.Drawing.Point(400, 1);
            this.lblCloaseFllower.Name = "lblCloaseFllower";
            this.lblCloaseFllower.Size = new System.Drawing.Size(29, 34);
            this.lblCloaseFllower.TabIndex = 4;
            this.lblCloaseFllower.Text = "X";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Floor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 9);
            this.panel2.TabIndex = 0;
            // 
            // txtNameOfFloower
            // 
            this.txtNameOfFloower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNameOfFloower.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNameOfFloower.Location = new System.Drawing.Point(10, 119);
            this.txtNameOfFloower.Name = "txtNameOfFloower";
            this.txtNameOfFloower.Size = new System.Drawing.Size(410, 33);
            this.txtNameOfFloower.TabIndex = 0;
            this.txtNameOfFloower.Enter += new System.EventHandler(this.txtNameOfFloower_Enter);
            this.txtNameOfFloower.Leave += new System.EventHandler(this.txtNameOfFloower_Leave);
            // 
            // btnSaveFllower
            // 
            this.btnSaveFllower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFllower.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaveFllower.FlatAppearance.BorderSize = 2;
            this.btnSaveFllower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFllower.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveFllower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.btnSaveFllower.Location = new System.Drawing.Point(149, 270);
            this.btnSaveFllower.Name = "btnSaveFllower";
            this.btnSaveFllower.Size = new System.Drawing.Size(118, 42);
            this.btnSaveFllower.TabIndex = 2;
            this.btnSaveFllower.Text = "Save";
            this.btnSaveFllower.UseVisualStyleBackColor = false;
            // 
            // txtNumOfRoom
            // 
            this.txtNumOfRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNumOfRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNumOfRoom.Location = new System.Drawing.Point(9, 202);
            this.txtNumOfRoom.Name = "txtNumOfRoom";
            this.txtNumOfRoom.Size = new System.Drawing.Size(410, 33);
            this.txtNumOfRoom.TabIndex = 4;
            this.txtNumOfRoom.Enter += new System.EventHandler(this.txtNameOfFloower_Enter);
            this.txtNumOfRoom.Leave += new System.EventHandler(this.txtNameOfFloower_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Rooms";
            // 
            // AddOrEditFloors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(429, 350);
            this.Controls.Add(this.txtNumOfRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNameOfFloower);
            this.Controls.Add(this.btnSaveFllower);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrEditFloors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrEditFloors";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCloseFllower;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveFllower;
        private System.Windows.Forms.TextBox txtNumOfRoom;
        private System.Windows.Forms.TextBox txtNameOfFloower;
        private Label lblCloaseFllower;
    }
}