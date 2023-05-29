﻿using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystemManagement
{
    partial class AddDepartmentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescriptionOfDept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameOfDept = new System.Windows.Forms.TextBox();
            this.btnSaveFllower = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 39);
            this.panel1.TabIndex = 10;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblClose.Location = new System.Drawing.Point(443, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 25);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "x";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.label1.Font = new System.Drawing.Font("Pangolin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::HospitalSystemManagement.Properties.Resources.addBig1;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(7, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Department";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescriptionOfDept
            // 
            this.txtDescriptionOfDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescriptionOfDept.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtDescriptionOfDept.Location = new System.Drawing.Point(29, 178);
            this.txtDescriptionOfDept.Name = "txtDescriptionOfDept";
            this.txtDescriptionOfDept.Size = new System.Drawing.Size(410, 33);
            this.txtDescriptionOfDept.TabIndex = 14;
            this.txtDescriptionOfDept.Enter += new System.EventHandler(this.txtNameOfDept_Enter);
            this.txtDescriptionOfDept.Leave += new System.EventHandler(this.txtNameOfDept_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Description";
            // 
            // txtNameOfDept
            // 
            this.txtNameOfDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNameOfDept.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNameOfDept.Location = new System.Drawing.Point(30, 95);
            this.txtNameOfDept.Name = "txtNameOfDept";
            this.txtNameOfDept.Size = new System.Drawing.Size(410, 33);
            this.txtNameOfDept.TabIndex = 11;
            this.txtNameOfDept.Enter += new System.EventHandler(this.txtNameOfDept_Enter);
            this.txtNameOfDept.Leave += new System.EventHandler(this.txtNameOfDept_Leave);
            // 
            // btnSaveFllower
            // 
            this.btnSaveFllower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFllower.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaveFllower.FlatAppearance.BorderSize = 2;
            this.btnSaveFllower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFllower.Font = new System.Drawing.Font("Pangolin", 18F, System.Drawing.FontStyle.Bold);
            this.btnSaveFllower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveFllower.Location = new System.Drawing.Point(169, 279);
            this.btnSaveFllower.Name = "btnSaveFllower";
            this.btnSaveFllower.Size = new System.Drawing.Size(118, 45);
            this.btnSaveFllower.TabIndex = 13;
            this.btnSaveFllower.Text = "Save";
            this.btnSaveFllower.UseVisualStyleBackColor = false;
            this.btnSaveFllower.Click += new System.EventHandler(this.btnSaveFllower_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(82, 236);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblError.Size = new System.Drawing.Size(281, 28);
            this.lblError.TabIndex = 35;
            this.lblError.Text = "Invalid Name or Description  !!!!!!";
            this.lblError.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Pangolin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(169, 279);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 45);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(468, 352);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtDescriptionOfDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameOfDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSaveFllower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDepartmentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveFllower;
        private System.Windows.Forms.TextBox txtNameOfDept;
        private System.Windows.Forms.TextBox txtDescriptionOfDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label3;
        private Label lblError;
        private Button btnUpdate;
    }
}