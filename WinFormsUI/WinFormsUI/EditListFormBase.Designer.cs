namespace WinFormsUI
{
    partial class EditListFormBase
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
        protected void InitializeComponent()
        {
            listBoxItems = new ListBox();
            txtNewItem = new TextBox();
            AddBtn = new Button();
            EditBtn = new Button();
            CancelBtn = new Button();
            SaveBtn = new Button();
            DeleteBtn = new Button();
            txtEditItem = new TextBox();
            SuspendLayout();
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(17, 12);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(449, 304);
            listBoxItems.TabIndex = 0;
            // 
            // txtNewItem
            // 
            txtNewItem.Location = new Point(17, 322);
            txtNewItem.Name = "txtNewItem";
            txtNewItem.Size = new Size(100, 23);
            txtNewItem.TabIndex = 1;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(123, 322);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(310, 322);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 3;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(75, 361);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(350, 361);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 5;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(391, 322);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // txtEditItem
            // 
            txtEditItem.Location = new Point(204, 322);
            txtEditItem.Name = "txtEditItem";
            txtEditItem.Size = new Size(100, 23);
            txtEditItem.TabIndex = 7;
            // 
            // EditListFormBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 396);
            Controls.Add(txtEditItem);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(CancelBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(txtNewItem);
            Controls.Add(listBoxItems);
            Name = "EditListFormBase";
            Text = "Manage List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected ListBox listBoxItems;
        protected TextBox txtNewItem;
        protected Button AddBtn;
        protected Button EditBtn;
        protected Button CancelBtn;
        protected Button SaveBtn;
        protected Button DeleteBtn;
        protected TextBox txtEditItem;
    }
}