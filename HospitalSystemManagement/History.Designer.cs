using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystemManagement
{
    partial class History
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
            this.dgvDept = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmBoxMonthlyHistory = new System.Windows.Forms.ComboBox();
            this.cmBoxYealyHistory = new System.Windows.Forms.ComboBox();
            this.dtimepHistory = new System.Windows.Forms.DateTimePicker();
            this.btnPrintHistory = new System.Windows.Forms.Button();
            this.txtSearchHistory = new System.Windows.Forms.TextBox();
            this.btnSearchHistory = new System.Windows.Forms.Button();
            this.btnPrintDept = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchDept = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDept
            // 
            this.dgvDept.AllowUserToAddRows = false;
            this.dgvDept.AllowUserToDeleteRows = false;
            this.dgvDept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDept.BackgroundColor = System.Drawing.Color.White;
            this.dgvDept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDept.GridColor = System.Drawing.Color.White;
            this.dgvDept.Location = new System.Drawing.Point(0, 9);
            this.dgvDept.MultiSelect = false;
            this.dgvDept.Name = "dgvDept";
            this.dgvDept.ReadOnly = true;
            this.dgvDept.RowTemplate.Height = 25;
            this.dgvDept.Size = new System.Drawing.Size(866, 381);
            this.dgvDept.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 39);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "The History Of All Patient In Hospital";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.cmBoxMonthlyHistory);
            this.panel3.Controls.Add(this.cmBoxYealyHistory);
            this.panel3.Controls.Add(this.dtimepHistory);
            this.panel3.Controls.Add(this.btnPrintHistory);
            this.panel3.Controls.Add(this.txtSearchHistory);
            this.panel3.Controls.Add(this.btnSearchHistory);
            this.panel3.Controls.Add(this.btnPrintDept);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSearchDept);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 67);
            this.panel3.TabIndex = 11;
            // 
            // cmBoxMonthlyHistory
            // 
            this.cmBoxMonthlyHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxMonthlyHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmBoxMonthlyHistory.FormattingEnabled = true;
            this.cmBoxMonthlyHistory.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmBoxMonthlyHistory.Location = new System.Drawing.Point(143, 8);
            this.cmBoxMonthlyHistory.Name = "cmBoxMonthlyHistory";
            this.cmBoxMonthlyHistory.Size = new System.Drawing.Size(88, 33);
            this.cmBoxMonthlyHistory.TabIndex = 36;
            // 
            // cmBoxYealyHistory
            // 
            this.cmBoxYealyHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxYealyHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmBoxYealyHistory.FormattingEnabled = true;
            this.cmBoxYealyHistory.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cmBoxYealyHistory.Location = new System.Drawing.Point(10, 8);
            this.cmBoxYealyHistory.Name = "cmBoxYealyHistory";
            this.cmBoxYealyHistory.Size = new System.Drawing.Size(125, 33);
            this.cmBoxYealyHistory.TabIndex = 35;
            // 
            // dtimepHistory
            // 
            this.dtimepHistory.Font = new System.Drawing.Font("Pangolin", 12F);
            this.dtimepHistory.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimepHistory.Location = new System.Drawing.Point(236, 11);
            this.dtimepHistory.Name = "dtimepHistory";
            this.dtimepHistory.Size = new System.Drawing.Size(106, 27);
            this.dtimepHistory.TabIndex = 12;
            // 
            // btnPrintHistory
            // 
            this.btnPrintHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintHistory.Location = new System.Drawing.Point(812, 6);
            this.btnPrintHistory.Name = "btnPrintHistory";
            this.btnPrintHistory.Size = new System.Drawing.Size(44, 20);
            this.btnPrintHistory.TabIndex = 10;
            this.btnPrintHistory.Text = "Print";
            this.btnPrintHistory.UseVisualStyleBackColor = true;
            // 
            // txtSearchHistory
            // 
            this.txtSearchHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchHistory.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtSearchHistory.Location = new System.Drawing.Point(662, 31);
            this.txtSearchHistory.Name = "txtSearchHistory";
            this.txtSearchHistory.Size = new System.Drawing.Size(194, 34);
            this.txtSearchHistory.TabIndex = 9;
            this.txtSearchHistory.Enter += new System.EventHandler(this.txtSearchHistory_Enter);
            this.txtSearchHistory.Leave += new System.EventHandler(this.txtSearchHistory_Leave);
            // 
            // btnSearchHistory
            // 
            this.btnSearchHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchHistory.BackColor = System.Drawing.Color.White;
            this.btnSearchHistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchHistory.FlatAppearance.BorderSize = 0;
            this.btnSearchHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearchHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearchHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSearchHistory.ForeColor = System.Drawing.Color.Gray;
            this.btnSearchHistory.Location = new System.Drawing.Point(575, 29);
            this.btnSearchHistory.Name = "btnSearchHistory";
            this.btnSearchHistory.Size = new System.Drawing.Size(81, 32);
            this.btnSearchHistory.TabIndex = 8;
            this.btnSearchHistory.Text = "Search";
            this.btnSearchHistory.UseVisualStyleBackColor = false;
            // 
            // btnPrintDept
            // 
            this.btnPrintDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintDept.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintDept.Location = new System.Drawing.Point(1293, 7);
            this.btnPrintDept.Name = "btnPrintDept";
            this.btnPrintDept.Size = new System.Drawing.Size(44, 20);
            this.btnPrintDept.TabIndex = 7;
            this.btnPrintDept.Text = "Print";
            this.btnPrintDept.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtSearch.Location = new System.Drawing.Point(1143, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 34);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearchDept
            // 
            this.btnSearchDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchDept.BackColor = System.Drawing.Color.White;
            this.btnSearchDept.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchDept.FlatAppearance.BorderSize = 0;
            this.btnSearchDept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearchDept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearchDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDept.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSearchDept.ForeColor = System.Drawing.Color.Gray;
            this.btnSearchDept.Location = new System.Drawing.Point(1056, 29);
            this.btnSearchDept.Name = "btnSearchDept";
            this.btnSearchDept.Size = new System.Drawing.Size(81, 32);
            this.btnSearchDept.TabIndex = 3;
            this.btnSearchDept.Text = "Search";
            this.btnSearchDept.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(866, 9);
            this.panel5.TabIndex = 9;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 390);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDept);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDept;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Button btnPrintDept;
        private TextBox txtSearch;
        private Button btnSearchDept;
        private Panel panel5;
        private DateTimePicker dtimepHistory;
        private Button btnPrintHistory;
        private TextBox txtSearchHistory;
        private Button btnSearchHistory;
        private ComboBox cmBoxMonthlyHistory;
        private ComboBox cmBoxYealyHistory;
    }
}