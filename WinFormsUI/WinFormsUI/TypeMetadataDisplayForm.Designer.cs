namespace WinFormsUI
{
    partial class TypeMetadataDisplayForm
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
            txtBoxTypeMetadata = new TextBox();
            SuspendLayout();
            // 
            // txtBoxTypeMetadata
            // 
            txtBoxTypeMetadata.Location = new Point(12, 12);
            txtBoxTypeMetadata.Multiline = true;
            txtBoxTypeMetadata.Name = "txtBoxTypeMetadata";
            txtBoxTypeMetadata.Size = new Size(498, 426);
            txtBoxTypeMetadata.TabIndex = 1;
            // 
            // TypeMetadataDisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(txtBoxTypeMetadata);
            Name = "TypeMetadataDisplayForm";
            Text = "Metadata Display";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxTypeMetadata;
    }
}