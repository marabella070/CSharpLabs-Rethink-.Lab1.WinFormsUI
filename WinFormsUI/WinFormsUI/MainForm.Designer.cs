using System.Windows.Forms;

namespace WinFormsUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            toolStripAddBtn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripEditButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripDeleteBtn = new ToolStripButton();
            WorkshopGridView = new DataGridView();
            panelBrigades = new Panel();
            panelShifts = new Panel();
            panelSchedule = new Panel();
            panelProducts = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            programmToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WorkshopGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripAddBtn, toolStripSeparator1, toolStripEditButton, toolStripSeparator2, toolStripDeleteBtn });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1009, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip145";
            // 
            // toolStripAddBtn
            // 
            toolStripAddBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripAddBtn.Image = (Image)resources.GetObject("toolStripAddBtn.Image");
            toolStripAddBtn.ImageTransparentColor = Color.Magenta;
            toolStripAddBtn.Name = "toolStripAddBtn";
            toolStripAddBtn.Size = new Size(23, 22);
            toolStripAddBtn.Text = "toolStripButton1";
            toolStripAddBtn.Click += toolStripAddBtn_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripEditButton
            // 
            toolStripEditButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripEditButton.Image = (Image)resources.GetObject("toolStripEditButton.Image");
            toolStripEditButton.ImageTransparentColor = Color.Magenta;
            toolStripEditButton.Name = "toolStripEditButton";
            toolStripEditButton.Size = new Size(23, 22);
            toolStripEditButton.Text = "toolStripEditButton";
            toolStripEditButton.Click += toolStripEditButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripDeleteBtn
            // 
            toolStripDeleteBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDeleteBtn.Image = (Image)resources.GetObject("toolStripDeleteBtn.Image");
            toolStripDeleteBtn.ImageTransparentColor = Color.Magenta;
            toolStripDeleteBtn.Name = "toolStripDeleteBtn";
            toolStripDeleteBtn.Size = new Size(23, 22);
            toolStripDeleteBtn.Text = "toolStripButton2";
            toolStripDeleteBtn.Click += toolStripDeleteBtn_Click;
            // 
            // WorkshopGridView
            // 
            WorkshopGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WorkshopGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            WorkshopGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WorkshopGridView.Location = new Point(12, 52);
            WorkshopGridView.Name = "WorkshopGridView";
            WorkshopGridView.ReadOnly = true;
            WorkshopGridView.Size = new Size(495, 364);
            WorkshopGridView.TabIndex = 2;
            WorkshopGridView.CellClick += WorkshopGridView_CellClick;
            WorkshopGridView.RowPostPaint += WorkshopGridView_RowPostPaint;
            // 
            // panelBrigades
            // 
            panelBrigades.Location = new Point(636, 71);
            panelBrigades.Name = "panelBrigades";
            panelBrigades.Size = new Size(117, 345);
            panelBrigades.TabIndex = 3;
            // 
            // panelShifts
            // 
            panelShifts.Location = new Point(759, 71);
            panelShifts.Name = "panelShifts";
            panelShifts.Size = new Size(117, 345);
            panelShifts.TabIndex = 4;
            // 
            // panelSchedule
            // 
            panelSchedule.Location = new Point(882, 71);
            panelSchedule.Name = "panelSchedule";
            panelSchedule.Size = new Size(117, 345);
            panelSchedule.TabIndex = 5;
            // 
            // panelProducts
            // 
            panelProducts.Location = new Point(513, 71);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(117, 345);
            panelProducts.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, 52);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 7;
            label1.Text = "Product list:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(659, 52);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 8;
            label2.Text = "Brigades list:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(788, 52);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Shifts list:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(911, 52);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "Schedule:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, programmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1009, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(107, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // programmToolStripMenuItem
            // 
            programmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            programmToolStripMenuItem.Size = new Size(44, 20);
            programmToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 429);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelProducts);
            Controls.Add(panelSchedule);
            Controls.Add(panelShifts);
            Controls.Add(panelBrigades);
            Controls.Add(WorkshopGridView);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "DataWorkstation";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WorkshopGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripAddBtn;
        private DataGridView WorkshopGridView;
        private Panel panelBrigades;
        private Panel panelShifts;
        private Panel panelSchedule;
        private Panel panelProducts;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripEditButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripDeleteBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem programmToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}