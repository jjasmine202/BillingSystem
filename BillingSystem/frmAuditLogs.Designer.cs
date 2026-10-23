namespace BillingSystem
{
    partial class frmAuditLogs
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
            IblTitle = new Label();
            IblFrom = new Label();
            dtpFrom = new DateTimePicker();
            IblTo = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnSearch = new Button();
            dgvAuditLogs = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
            SuspendLayout();
            // 
            // IblTitle
            // 
            IblTitle.AutoSize = true;
            IblTitle.Font = new Font("Microsoft Sans Serif", 14F);
            IblTitle.Location = new Point(12, 9);
            IblTitle.Name = "IblTitle";
            IblTitle.Size = new Size(193, 29);
            IblTitle.TabIndex = 0;
            IblTitle.Text = "Audit Log Report";
            IblTitle.Click += IblTitle_Click;
            // 
            // IblFrom
            // 
            IblFrom.AutoSize = true;
            IblFrom.Location = new Point(12, 62);
            IblFrom.Name = "IblFrom";
            IblFrom.Size = new Size(46, 20);
            IblFrom.TabIndex = 1;
            IblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(64, 57);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 2;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // IblTo
            // 
            IblTo.AutoSize = true;
            IblTo.Location = new Point(391, 62);
            IblTo.Name = "IblTo";
            IblTo.Size = new Size(28, 20);
            IblTo.TabIndex = 3;
            IblTo.Text = "To:";
            IblTo.Click += dtpTo_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(425, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(739, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvAuditLogs
            // 
            dgvAuditLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLogs.Location = new Point(64, 114);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.RowHeadersWidth = 51;
            dgvAuditLogs.Size = new Size(769, 327);
            dgvAuditLogs.TabIndex = 6;
            dgvAuditLogs.CellContentClick += dgvAuditLogs_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(739, 462);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAuditLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(btnClose);
            Controls.Add(dgvAuditLogs);
            Controls.Add(btnSearch);
            Controls.Add(dateTimePicker1);
            Controls.Add(IblTo);
            Controls.Add(dtpFrom);
            Controls.Add(IblFrom);
            Controls.Add(IblTitle);
            Name = "frmAuditLogs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit Log Report";
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IblTitle;
        private Label IblFrom;
        private DateTimePicker dtpFrom;
        private Label IblTo;
        private DateTimePicker dateTimePicker1;
        private Button btnSearch;
        private DataGridView dgvAuditLogs;
        private Button btnClose;
    }
}