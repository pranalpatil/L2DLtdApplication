namespace L2DLtdApplication
{
    partial class L2DLtdApplicationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L2DLtdApplicationForm));
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.CourseListLabel = new System.Windows.Forms.Label();
            this.TrainingDayLabel = new System.Windows.Forms.Label();
            this.EnrollmentFeesLabel = new System.Windows.Forms.Label();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.LocationsLabel = new System.Windows.Forms.Label();
            this.AccommadationFeesPerDayLabel = new System.Windows.Forms.Label();
            this.attendeesTextBox = new System.Windows.Forms.TextBox();
            this.AttendeesLabel = new System.Windows.Forms.Label();
            this.UpgradesPanel = new System.Windows.Forms.Panel();
            this.juniorSuiteRadioButton = new System.Windows.Forms.RadioButton();
            this.executiveSuiteRadioButton = new System.Windows.Forms.RadioButton();
            this.masterSuiteRadioButton = new System.Windows.Forms.RadioButton();
            this.SuiteUpgradesLabel = new System.Windows.Forms.Label();
            this.CertificatePanel = new System.Windows.Forms.Panel();
            this.certificateCheckBox = new System.Windows.Forms.CheckBox();
            this.CertificateLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UpgradesPanel.SuspendLayout();
            this.CertificatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 32;
            this.courseListBox.Items.AddRange(new object[] {
            "C# Fundamentals\t\t2 Days\t   €900",
            "C# Basic for Beginners      \t4 Days\t   €1,500",
            "C# Intermediate\t          \t4 Days\t   €1,800",
            "C# Advanced Topic\t          \t2 Days\t   €2,300",
            "ASP.NET with C# Part A     \t5 Days\t   €1,250",
            "ASP.NET with C# Part B     \t5 Days\t   €1,250"});
            this.courseListBox.Location = new System.Drawing.Point(51, 78);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(537, 228);
            this.courseListBox.TabIndex = 0;
            // 
            // CourseListLabel
            // 
            this.CourseListLabel.AutoSize = true;
            this.CourseListLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CourseListLabel.Location = new System.Drawing.Point(51, 9);
            this.CourseListLabel.Name = "CourseListLabel";
            this.CourseListLabel.Size = new System.Drawing.Size(104, 32);
            this.CourseListLabel.TabIndex = 1;
            this.CourseListLabel.Text = "Courses";
            // 
            // TrainingDayLabel
            // 
            this.TrainingDayLabel.AutoSize = true;
            this.TrainingDayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrainingDayLabel.Location = new System.Drawing.Point(341, 9);
            this.TrainingDayLabel.Name = "TrainingDayLabel";
            this.TrainingDayLabel.Size = new System.Drawing.Size(108, 64);
            this.TrainingDayLabel.TabIndex = 2;
            this.TrainingDayLabel.Text = "Training\r\nDays";
            this.TrainingDayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EnrollmentFeesLabel
            // 
            this.EnrollmentFeesLabel.AutoSize = true;
            this.EnrollmentFeesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnrollmentFeesLabel.Location = new System.Drawing.Point(455, 9);
            this.EnrollmentFeesLabel.Name = "EnrollmentFeesLabel";
            this.EnrollmentFeesLabel.Size = new System.Drawing.Size(140, 64);
            this.EnrollmentFeesLabel.TabIndex = 3;
            this.EnrollmentFeesLabel.Text = "Enrollment\r\nFees";
            this.EnrollmentFeesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 32;
            this.locationListBox.Items.AddRange(new object[] {
            "Belmullet\t\t€219.99",
            "Clifton\t\t€119.99",
            "Cork \t\t€149.99",
            "Dublin\t\t€179.99",
            "Killarney\t\t€149.99",
            "Letterkenny\t€89.99",
            "Sligo\t\t€119.99"});
            this.locationListBox.Location = new System.Drawing.Point(612, 78);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(387, 228);
            this.locationListBox.TabIndex = 4;
            // 
            // LocationsLabel
            // 
            this.LocationsLabel.AutoSize = true;
            this.LocationsLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocationsLabel.Location = new System.Drawing.Point(612, 11);
            this.LocationsLabel.Name = "LocationsLabel";
            this.LocationsLabel.Size = new System.Drawing.Size(126, 32);
            this.LocationsLabel.TabIndex = 5;
            this.LocationsLabel.Text = "Locations";
            // 
            // AccommadationFeesPerDayLabel
            // 
            this.AccommadationFeesPerDayLabel.AutoSize = true;
            this.AccommadationFeesPerDayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccommadationFeesPerDayLabel.Location = new System.Drawing.Point(777, 11);
            this.AccommadationFeesPerDayLabel.Name = "AccommadationFeesPerDayLabel";
            this.AccommadationFeesPerDayLabel.Size = new System.Drawing.Size(201, 64);
            this.AccommadationFeesPerDayLabel.TabIndex = 6;
            this.AccommadationFeesPerDayLabel.Text = "Accommadation\r\nFees Per Day";
            this.AccommadationFeesPerDayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // attendeesTextBox
            // 
            this.attendeesTextBox.Location = new System.Drawing.Point(1051, 84);
            this.attendeesTextBox.Name = "attendeesTextBox";
            this.attendeesTextBox.Size = new System.Drawing.Size(206, 39);
            this.attendeesTextBox.TabIndex = 7;
            // 
            // AttendeesLabel
            // 
            this.AttendeesLabel.AutoSize = true;
            this.AttendeesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AttendeesLabel.Location = new System.Drawing.Point(1079, 11);
            this.AttendeesLabel.Name = "AttendeesLabel";
            this.AttendeesLabel.Size = new System.Drawing.Size(149, 64);
            this.AttendeesLabel.TabIndex = 8;
            this.AttendeesLabel.Text = "Enter no of \r\nAttendees";
            this.AttendeesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpgradesPanel
            // 
            this.UpgradesPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpgradesPanel.Controls.Add(this.juniorSuiteRadioButton);
            this.UpgradesPanel.Controls.Add(this.executiveSuiteRadioButton);
            this.UpgradesPanel.Controls.Add(this.masterSuiteRadioButton);
            this.UpgradesPanel.Location = new System.Drawing.Point(1311, 78);
            this.UpgradesPanel.Name = "UpgradesPanel";
            this.UpgradesPanel.Size = new System.Drawing.Size(326, 145);
            this.UpgradesPanel.TabIndex = 9;
            // 
            // juniorSuiteRadioButton
            // 
            this.juniorSuiteRadioButton.AutoSize = true;
            this.juniorSuiteRadioButton.Location = new System.Drawing.Point(15, 93);
            this.juniorSuiteRadioButton.Name = "juniorSuiteRadioButton";
            this.juniorSuiteRadioButton.Size = new System.Drawing.Size(290, 36);
            this.juniorSuiteRadioButton.TabIndex = 2;
            this.juniorSuiteRadioButton.TabStop = true;
            this.juniorSuiteRadioButton.Text = "Junior Suite      €49.99 ";
            this.juniorSuiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // executiveSuiteRadioButton
            // 
            this.executiveSuiteRadioButton.AutoSize = true;
            this.executiveSuiteRadioButton.Location = new System.Drawing.Point(15, 51);
            this.executiveSuiteRadioButton.Name = "executiveSuiteRadioButton";
            this.executiveSuiteRadioButton.Size = new System.Drawing.Size(290, 36);
            this.executiveSuiteRadioButton.TabIndex = 1;
            this.executiveSuiteRadioButton.TabStop = true;
            this.executiveSuiteRadioButton.Text = "Executive Suite €69.99 \r\n";
            this.executiveSuiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // masterSuiteRadioButton
            // 
            this.masterSuiteRadioButton.AutoSize = true;
            this.masterSuiteRadioButton.Location = new System.Drawing.Point(14, 9);
            this.masterSuiteRadioButton.Name = "masterSuiteRadioButton";
            this.masterSuiteRadioButton.Size = new System.Drawing.Size(291, 36);
            this.masterSuiteRadioButton.TabIndex = 0;
            this.masterSuiteRadioButton.TabStop = true;
            this.masterSuiteRadioButton.Text = "Master Suite     €99.99 \r\n";
            this.masterSuiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // SuiteUpgradesLabel
            // 
            this.SuiteUpgradesLabel.AutoSize = true;
            this.SuiteUpgradesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SuiteUpgradesLabel.Location = new System.Drawing.Point(1376, 9);
            this.SuiteUpgradesLabel.Name = "SuiteUpgradesLabel";
            this.SuiteUpgradesLabel.Size = new System.Drawing.Size(187, 32);
            this.SuiteUpgradesLabel.TabIndex = 10;
            this.SuiteUpgradesLabel.Text = "Suite Upgrades";
            // 
            // CertificatePanel
            // 
            this.CertificatePanel.BackColor = System.Drawing.SystemColors.Control;
            this.CertificatePanel.Controls.Add(this.certificateCheckBox);
            this.CertificatePanel.Controls.Add(this.CertificateLabel);
            this.CertificatePanel.Location = new System.Drawing.Point(1312, 245);
            this.CertificatePanel.Name = "CertificatePanel";
            this.CertificatePanel.Size = new System.Drawing.Size(325, 61);
            this.CertificatePanel.TabIndex = 11;
            // 
            // certificateCheckBox
            // 
            this.certificateCheckBox.AutoSize = true;
            this.certificateCheckBox.Location = new System.Drawing.Point(13, 13);
            this.certificateCheckBox.Name = "certificateCheckBox";
            this.certificateCheckBox.Size = new System.Drawing.Size(231, 36);
            this.certificateCheckBox.TabIndex = 1;
            this.certificateCheckBox.Text = "Certificate €39.99";
            this.certificateCheckBox.UseVisualStyleBackColor = true;
            // 
            // CertificateLabel
            // 
            this.CertificateLabel.AutoSize = true;
            this.CertificateLabel.Location = new System.Drawing.Point(86, 13);
            this.CertificateLabel.Name = "CertificateLabel";
            this.CertificateLabel.Size = new System.Drawing.Size(0, 32);
            this.CertificateLabel.TabIndex = 0;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(1019, 141);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(272, 165);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 12;
            this.LogoPictureBox.TabStop = false;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(51, 378);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(948, 368);
            this.outputLabel.TabIndex = 13;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(1240, 372);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(224, 46);
            this.DisplayButton.TabIndex = 14;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Enabled = false;
            this.bookButton.Location = new System.Drawing.Point(1240, 456);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(224, 46);
            this.bookButton.TabIndex = 15;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(1240, 542);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(224, 46);
            this.SummaryButton.TabIndex = 16;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1240, 624);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(224, 46);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1240, 700);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(224, 46);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // L2DLtdApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 818);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.CertificatePanel);
            this.Controls.Add(this.SuiteUpgradesLabel);
            this.Controls.Add(this.UpgradesPanel);
            this.Controls.Add(this.AttendeesLabel);
            this.Controls.Add(this.attendeesTextBox);
            this.Controls.Add(this.AccommadationFeesPerDayLabel);
            this.Controls.Add(this.LocationsLabel);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.EnrollmentFeesLabel);
            this.Controls.Add(this.TrainingDayLabel);
            this.Controls.Add(this.CourseListLabel);
            this.Controls.Add(this.courseListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "L2DLtdApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to L2D Ltd";
            this.UpgradesPanel.ResumeLayout(false);
            this.UpgradesPanel.PerformLayout();
            this.CertificatePanel.ResumeLayout(false);
            this.CertificatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox courseListBox;
        private Label CourseListLabel;
        private Label TrainingDayLabel;
        private Label EnrollmentFeesLabel;
        private ListBox locationListBox;
        private Label LocationsLabel;
        private Label AccommadationFeesPerDayLabel;
        private TextBox attendeesTextBox;
        private Label AttendeesLabel;
        private Panel UpgradesPanel;
        private RadioButton juniorSuiteRadioButton;
        private RadioButton executiveSuiteRadioButton;
        private RadioButton masterSuiteRadioButton;
        private Label SuiteUpgradesLabel;
        private Panel CertificatePanel;
        private CheckBox certificateCheckBox;
        private Label CertificateLabel;
        private PictureBox LogoPictureBox;
        private Label outputLabel;
        private Button DisplayButton;
        private Button bookButton;
        private Button SummaryButton;
        private Button ClearButton;
        private Button ExitButton;
    }
}