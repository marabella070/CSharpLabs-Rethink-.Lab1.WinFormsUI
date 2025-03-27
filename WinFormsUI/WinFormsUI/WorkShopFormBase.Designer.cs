using CoreAPI.Core.Models;

namespace WinFormsUI
{
    partial class WorkShopFormBase
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
        private void InitializeComponent(string formText)
        {
            txtProductionName = new TextBox();
            txtManagerName = new TextBox();
            numWorkerCount = new NumericUpDown();
            numId = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CancelBtn = new Button();
            SaveBtn = new Button();
            label5 = new Label();
            EditProductsBtn = new Button();
            EditBrigadesBtn = new Button();
            label6 = new Label();
            scheduleComboBox = new ComboBox();
            label7 = new Label();
            scheduleDetails = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numWorkerCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            SuspendLayout();
            // 
            // txtProductionName
            // 
            txtProductionName.Location = new Point(130, 12);
            txtProductionName.Name = "txtProductionName";
            txtProductionName.Size = new Size(154, 23);
            txtProductionName.TabIndex = 0;
            // 
            // txtManagerName
            // 
            txtManagerName.Location = new Point(130, 41);
            txtManagerName.Name = "txtManagerName";
            txtManagerName.Size = new Size(154, 23);
            txtManagerName.TabIndex = 1;
            // 
            // numWorkerCount
            // 
            numWorkerCount.Location = new Point(130, 70);
            numWorkerCount.Name = "numWorkerCount";
            numWorkerCount.Size = new Size(154, 23);
            numWorkerCount.TabIndex = 2;
            numWorkerCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numId
            // 
            numId.Location = new Point(130, 99);
            numId.Maximum = new decimal(new int[] { 98, 0, 0, 0 });
            numId.Minimum = new decimal(new int[] { 98, 0, 0, 0 });
            numId.Name = "numId";
            numId.Size = new Size(154, 23);
            numId.TabIndex = 3;
            numId.Value = new decimal(new int[] { 98, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 4;
            label1.Text = "Production name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 44);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 5;
            label2.Text = "Manager name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 72);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Worker count:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 101);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 7;
            label4.Text = "Workshop ID:";
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(22, 288);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 8;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(209, 288);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 9;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 221);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 10;
            label5.Text = "Production list:";
            // 
            // EditProductsBtn
            // 
            EditProductsBtn.Location = new Point(130, 217);
            EditProductsBtn.Name = "EditProductsBtn";
            EditProductsBtn.Size = new Size(75, 23);
            EditProductsBtn.TabIndex = 11;
            EditProductsBtn.Text = "Edit";
            EditProductsBtn.UseVisualStyleBackColor = true;
            EditProductsBtn.Click += EditProductsBtn_Click;
            // 
            // EditBrigadesBtn
            // 
            EditBrigadesBtn.Location = new Point(130, 246);
            EditBrigadesBtn.Name = "EditBrigadesBtn";
            EditBrigadesBtn.Size = new Size(75, 23);
            EditBrigadesBtn.TabIndex = 12;
            EditBrigadesBtn.Text = "Edit";
            EditBrigadesBtn.UseVisualStyleBackColor = true;
            EditBrigadesBtn.Click += EditBrigadesBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 250);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 13;
            label6.Text = "Brigades list:";
            // 
            // scheduleComboBox
            // 
            scheduleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            scheduleComboBox.FormattingEnabled = true;
            scheduleComboBox.Items.AddRange(new object[] { "Three-Shift, Four-Brigade", "Three-Shift, Five-Brigade" });
            scheduleComboBox.Location = new Point(130, 128);
            scheduleComboBox.Name = "scheduleComboBox";
            scheduleComboBox.Size = new Size(154, 23);
            scheduleComboBox.TabIndex = 14;
            scheduleComboBox.SelectedIndexChanged += scheduleComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 131);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 15;
            label7.Text = "Schedule:";
            // 
            // scheduleDetails
            // 
            scheduleDetails.Location = new Point(130, 157);
            scheduleDetails.Multiline = true;
            scheduleDetails.Name = "scheduleDetails";
            scheduleDetails.ReadOnly = true;
            scheduleDetails.Size = new Size(154, 54);
            scheduleDetails.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 160);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 17;
            label8.Text = "Schedule details:";
            // 
            // WorkShopFormBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 331);
            Controls.Add(label8);
            Controls.Add(scheduleDetails);
            Controls.Add(label7);
            Controls.Add(scheduleComboBox);
            Controls.Add(label6);
            Controls.Add(EditBrigadesBtn);
            Controls.Add(EditProductsBtn);
            Controls.Add(label5);
            Controls.Add(SaveBtn);
            Controls.Add(CancelBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numId);
            Controls.Add(numWorkerCount);
            Controls.Add(txtManagerName);
            Controls.Add(txtProductionName);
            Name = "WorkShopFormBase";
            Text = formText;
            ((System.ComponentModel.ISupportInitialize)numWorkerCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected TextBox txtProductionName;
        protected TextBox txtManagerName;
        protected NumericUpDown numWorkerCount;
        protected NumericUpDown numId;
        protected Label label1;
        protected Label label2;
        protected Label label3;
        protected Label label4;
        protected Button CancelBtn;
        protected Button SaveBtn;
        protected Label label5;
        protected Button EditProductsBtn;
        protected Button EditBrigadesBtn;
        protected Label label6;
        private ComboBox scheduleComboBox;
        protected Label label7;
        private TextBox scheduleDetails;
        protected Label label8;
    }
}