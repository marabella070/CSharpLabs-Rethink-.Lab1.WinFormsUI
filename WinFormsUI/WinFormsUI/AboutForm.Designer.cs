namespace WinFormsUI
{
    partial class AboutForm
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
            lblAppName = new Label();
            lblVersion = new Label();
            lblAuthor = new Label();
            lblDescription = new Label();
            btnOk = new Button();
            projectLinkLabel = new LinkLabel();
            featuresListBox = new ListBox();
            lblFeaturesAndFunc = new Label();
            lblGeneralInfo = new Label();
            lblDiscipline = new Label();
            lblTeacher = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Location = new Point(24, 34);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(101, 15);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Application name";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(24, 59);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(45, 15);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(24, 84);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(60, 15);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Developer";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(24, 109);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(133, 440);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // projectLinkLabel
            // 
            projectLinkLabel.AutoSize = true;
            projectLinkLabel.Location = new Point(25, 407);
            projectLinkLabel.Name = "projectLinkLabel";
            projectLinkLabel.Size = new Size(301, 15);
            projectLinkLabel.TabIndex = 5;
            projectLinkLabel.TabStop = true;
            projectLinkLabel.Text = "https://github.com/marabella070/CSharpLabs-Rethink-";
            projectLinkLabel.LinkClicked += projectLinkLabel_LinkClicked;
            // 
            // featuresListBox
            // 
            featuresListBox.FormattingEnabled = true;
            featuresListBox.Location = new Point(25, 211);
            featuresListBox.Name = "featuresListBox";
            featuresListBox.Size = new Size(271, 184);
            featuresListBox.TabIndex = 6;
            // 
            // lblFeaturesAndFunc
            // 
            lblFeaturesAndFunc.AutoSize = true;
            lblFeaturesAndFunc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFeaturesAndFunc.Location = new Point(25, 193);
            lblFeaturesAndFunc.Name = "lblFeaturesAndFunc";
            lblFeaturesAndFunc.Size = new Size(155, 15);
            lblFeaturesAndFunc.TabIndex = 7;
            lblFeaturesAndFunc.Text = "Features and Functionality:";
            // 
            // lblGeneralInfo
            // 
            lblGeneralInfo.AutoSize = true;
            lblGeneralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGeneralInfo.Location = new Point(25, 9);
            lblGeneralInfo.Name = "lblGeneralInfo";
            lblGeneralInfo.Size = new Size(124, 15);
            lblGeneralInfo.TabIndex = 8;
            lblGeneralInfo.Text = "General Information:";
            // 
            // lblDiscipline
            // 
            lblDiscipline.AutoSize = true;
            lblDiscipline.Location = new Point(24, 142);
            lblDiscipline.Name = "lblDiscipline";
            lblDiscipline.Size = new Size(58, 15);
            lblDiscipline.TabIndex = 9;
            lblDiscipline.Text = "Discipline";
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Location = new Point(25, 167);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(47, 15);
            lblTeacher.TabIndex = 10;
            lblTeacher.Text = "Teacher";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 477);
            Controls.Add(lblTeacher);
            Controls.Add(lblDiscipline);
            Controls.Add(lblGeneralInfo);
            Controls.Add(lblFeaturesAndFunc);
            Controls.Add(featuresListBox);
            Controls.Add(projectLinkLabel);
            Controls.Add(btnOk);
            Controls.Add(lblDescription);
            Controls.Add(lblAuthor);
            Controls.Add(lblVersion);
            Controls.Add(lblAppName);
            Name = "AboutForm";
            Text = "About Data Workstation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Label lblVersion;
        private Label lblAuthor;
        private Label lblDescription;
        private Button btnOk;
        private LinkLabel projectLinkLabel;
        private ListBox featuresListBox;
        private Label lblFeaturesAndFunc;
        private Label lblGeneralInfo;
        private Label lblDiscipline;
        private Label lblTeacher;
    }
}