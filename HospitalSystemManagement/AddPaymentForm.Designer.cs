using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystemManagement
{
    partial class AddPaymentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmBoxPatientName = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPaymented = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRemained = new System.Windows.Forms.TextBox();
            this.radioPaid = new System.Windows.Forms.RadioButton();
            this.radioUnpaid = new System.Windows.Forms.RadioButton();
            this.btnDone = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 9;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblClose.Location = new System.Drawing.Point(444, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 25);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "x";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Payments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Patient Name : ";
            // 
            // cmBoxPatientName
            // 
            this.cmBoxPatientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxPatientName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmBoxPatientName.FormattingEnabled = true;
            this.cmBoxPatientName.Location = new System.Drawing.Point(163, 73);
            this.cmBoxPatientName.Name = "cmBoxPatientName";
            this.cmBoxPatientName.Size = new System.Drawing.Size(266, 33);
            this.cmBoxPatientName.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtTotal.Location = new System.Drawing.Point(163, 171);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(266, 33);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Enter += new System.EventHandler(this.txtTotal_Enter);
            this.txtTotal.Leave += new System.EventHandler(this.txtTotal_Leave);
            // 
            // txtPaymented
            // 
            this.txtPaymented.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPaymented.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPaymented.Location = new System.Drawing.Point(159, 223);
            this.txtPaymented.Name = "txtPaymented";
            this.txtPaymented.Size = new System.Drawing.Size(92, 33);
            this.txtPaymented.TabIndex = 15;
            this.txtPaymented.Enter += new System.EventHandler(this.txtTotal_Enter);
            this.txtPaymented.Leave += new System.EventHandler(this.txtTotal_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(99, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(99, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 33);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(54, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Paymented : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(252, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Remained : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(92, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Status : ";
            // 
            // txtRemained
            // 
            this.txtRemained.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRemained.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtRemained.Location = new System.Drawing.Point(340, 223);
            this.txtRemained.Name = "txtRemained";
            this.txtRemained.Size = new System.Drawing.Size(94, 33);
            this.txtRemained.TabIndex = 27;
            this.txtRemained.Enter += new System.EventHandler(this.txtTotal_Enter);
            this.txtRemained.Leave += new System.EventHandler(this.txtTotal_Leave);
            // 
            // radioPaid
            // 
            this.radioPaid.AutoSize = true;
            this.radioPaid.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.radioPaid.Location = new System.Drawing.Point(163, 268);
            this.radioPaid.Name = "radioPaid";
            this.radioPaid.Size = new System.Drawing.Size(66, 29);
            this.radioPaid.TabIndex = 28;
            this.radioPaid.TabStop = true;
            this.radioPaid.Text = "Paid";
            this.radioPaid.UseVisualStyleBackColor = true;
            // 
            // radioUnpaid
            // 
            this.radioUnpaid.AutoSize = true;
            this.radioUnpaid.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.radioUnpaid.Location = new System.Drawing.Point(238, 268);
            this.radioUnpaid.Name = "radioUnpaid";
            this.radioUnpaid.Size = new System.Drawing.Size(91, 29);
            this.radioUnpaid.TabIndex = 30;
            this.radioUnpaid.TabStop = true;
            this.radioUnpaid.Text = "Unpaid";
            this.radioUnpaid.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(193)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(185, 333);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(107, 34);
            this.btnDone.TabIndex = 31;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // AddPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(468, 425);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.radioUnpaid);
            this.Controls.Add(this.radioPaid);
            this.Controls.Add(this.txtRemained);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPaymented);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmBoxPatientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPaymentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioUnpaid;
        private System.Windows.Forms.RadioButton radioPaid;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPaymented;
        private System.Windows.Forms.TextBox txtRemained;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBoxPatientName;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}