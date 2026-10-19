namespace BillingSystem
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private void label1_Click(object sender, EventArgs e)
        {
            // No action needed when the label is clicked.
        }

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
            components = new System.ComponentModel.Container();
            IbIAppName = new Label();
            IbITagline = new Label();
            IbILoading = new Label();
            splashTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // IbIAppName
            // 
            IbIAppName.AutoSize = true;
            IbIAppName.Font = new Font("Microsoft Sans Serif", 8.25F);
            IbIAppName.ForeColor = Color.White;
            IbIAppName.Location = new Point(195, 199);
            IbIAppName.Name = "IbIAppName";
            IbIAppName.Size = new Size(120, 17);
            IbIAppName.TabIndex = 0;
            IbIAppName.Text = "BILLING SYSTEM";
            IbIAppName.TextAlign = ContentAlignment.MiddleCenter;
            IbIAppName.Click += label1_Click;
            // 
            // IbITagline
            // 
            IbITagline.Font = new Font("Microsoft Sans Serif", 8.25F);
            IbITagline.ForeColor = Color.FromArgb(189, 215, 238);
            IbITagline.Location = new Point(220, 139);
            IbITagline.Name = "IbITagline";
            IbITagline.Size = new Size(62, 25);
            IbITagline.TabIndex = 1;
            IbITagline.Text = "Electric Billing Management System";
            IbITagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IbILoading
            // 
            IbILoading.Font = new Font("Microsoft Sans Serif", 9F);
            IbILoading.ForeColor = Color.FromArgb(189, 215, 238);
            IbILoading.Location = new Point(220, 86);
            IbILoading.Name = "IbILoading";
            IbILoading.Size = new Size(62, 25);
            IbILoading.TabIndex = 2;
            IbILoading.Text = "Loading...";
            IbILoading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splashTimer
            // 
            splashTimer.Interval = 2500;
            splashTimer.Tick += splashTimer_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(IbILoading);
            Controls.Add(IbITagline);
            Controls.Add(IbIAppName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IbIAppName;
        private Label IbITagline;
        private Label IbILoading;
        private System.Windows.Forms.Timer splashTimer;
    }
}