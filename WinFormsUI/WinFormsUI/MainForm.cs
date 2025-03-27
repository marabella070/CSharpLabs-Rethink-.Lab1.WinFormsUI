using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoreAPI.Core.Models;

namespace WinFormsUI
{
    public partial class MainForm : Form
    {
        private BindingList<Workshop> _workshops;

        public MainForm(List<Workshop> workshops)
        {
            InitializeComponent();

            _workshops = new BindingList<Workshop>(workshops ?? new List<Workshop>());

            InitializeWorkshopGridView();
        }

        // Method for initializing the DataGridView
        private void InitializeWorkshopGridView()
        {
            // Configuring the DataGridView
            WorkshopGridView.AutoGenerateColumns = false;
            WorkshopGridView.Columns.Clear();

            // Adding columns to the DataGridView
            WorkshopGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            WorkshopGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Manager", DataPropertyName = "Manager" });
            WorkshopGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Worker Count", DataPropertyName = "WorkerCount" });
            WorkshopGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Workshop ID", DataPropertyName = "Id" });

            // Data binding
            WorkshopGridView.DataSource = _workshops;
        }

        // ToolStrip
        private void toolStripAddBtn_Click(object sender, EventArgs e) => AddWorkshop();
        private void toolStripEditButton_Click(object sender, EventArgs e) => EditWorkshop();
        private void toolStripDeleteBtn_Click(object sender, EventArgs e) => DeleteWorkshop();

        // MenuStrip
        private void addToolStripMenuItem_Click(object sender, EventArgs e) => AddWorkshop();
        private void editToolStripMenuItem_Click(object sender, EventArgs e) => EditWorkshop();
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) => DeleteWorkshop();

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }
        }

        private void AddWorkshop()
        {
            using (var addForm = new AddWorkshopForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Adding an item after editing
                    _workshops.Add(addForm.NewWorkshop);

                    // Updating the DataGridView
                    WorkshopGridView.Refresh();
                }
            }
        }

        private void EditWorkshop()
        {
            var selectedWorkshopIndex = GetSelectedWorkshopIndex();

            if (selectedWorkshopIndex != -1)
            {
                // Opening the editing form for the selected object
                using (var editForm = new EditWorkshopForm(_workshops[selectedWorkshopIndex]))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Updating the item after editing
                        _workshops[selectedWorkshopIndex] = editForm.EditedWorkshop;

                        // Updating the DataGridView
                        WorkshopGridView.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an object to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteWorkshop()
        {
            var selectedWorkshopIndex = GetSelectedWorkshopIndex();

            if (selectedWorkshopIndex != -1)
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected object?", "Delete Confirmation",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _workshops.RemoveAt(selectedWorkshopIndex);
                }
            }
            else
            {
                MessageBox.Show("Select an object to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void WorkshopGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check that the click was on the cell, and not on the row or column header
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Getting the Workshop object associated with the selected row
                var selectedRow = WorkshopGridView.Rows[e.RowIndex];
                var workshop = selectedRow.DataBoundItem as Workshop;

                if (workshop != null)
                {
                    // Displaying the data on the panels
                    DisplayWorkshopDetails(workshop);
                }
            }
        }

        private void DisplayWorkshopDetails(Workshop workshop)
        {
            // Product Panel
            panelProducts.Controls.Clear();
            var productListBox = new ListBox
            {
                Dock = DockStyle.Fill,
                HorizontalScrollbar = true
            };
            productListBox.Items.AddRange(workshop.ProductList.ToArray());
            panelProducts.Controls.Add(productListBox);

            // Brigade Panel
            panelBrigades.Controls.Clear();
            var brigadeListBox = new ListBox
            {
                Dock = DockStyle.Fill,
                HorizontalScrollbar = true
            };
            brigadeListBox.Items.AddRange(workshop.Brigades.Select(b => b.Name).ToArray());
            panelBrigades.Controls.Add(brigadeListBox);

            // Shift Panel
            panelShifts.Controls.Clear();
            var shiftListBox = new ListBox
            {
                Dock = DockStyle.Fill,
                HorizontalScrollbar = true
            };
            shiftListBox.Items.AddRange(workshop.Shifts.ToArray());
            panelShifts.Controls.Add(shiftListBox);

            // Schedule Panel
            panelSchedule.Controls.Clear();
            var scheduleListBox = new ListBox
            {
                Dock = DockStyle.Fill,
                HorizontalScrollbar = true
            };
            scheduleListBox.Items.AddRange(workshop.Schedule.ToArray());
            panelSchedule.Controls.Add(scheduleListBox);
        }

        private void WorkshopGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Getting a DataGridView
            var grid = sender as DataGridView;

            // Numbering starts from 1
            var rowNumber = (e.RowIndex + 1).ToString();

            // Defining the area for line number rendering
            var headerBounds = new Rectangle(
                e.RowBounds.Left, // X
                e.RowBounds.Top,  // Y
                grid.RowHeadersWidth - 4,
                e.RowBounds.Height);

            // Setting up the text format
            var format = new StringFormat
            {
                Alignment = StringAlignment.Far, // Right alignment
                LineAlignment = StringAlignment.Center // Vertical center alignment
            };

            // Drawing the line number
            using (var brush = new SolidBrush(grid.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    rowNumber, // Text (line number)
                    grid.RowHeadersDefaultCellStyle.Font, // Font
                    brush, // Brush
                    headerBounds, // The rendering area
                    format); // Format
            }
        }

        private int GetSelectedWorkshopIndex()
        {
            // Get the currently selected cell
            var currentCell = WorkshopGridView.CurrentCell;

            if (currentCell != null)
            {
                // Getting the row that the cell belongs to
                var selectedRow = currentCell.OwningRow;

                if (selectedRow != null)
                {
                    // Getting the row index
                    int selectedIndex = selectedRow.Index;

                    // Check that the index is within the list
                    if (selectedIndex >= 0 && selectedIndex < _workshops.Count)
                    {
                        return selectedIndex;
                    }
                }
            }
            return -1;
        }
    }
}
