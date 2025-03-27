using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreAPI.Core.Models;

namespace WinFormsUI
{
    public abstract partial class WorkShopFormBase : Form
    {
        protected Workshop _workshop;
        public WorkShopFormBase(string formName)
        {
            InitializeComponent(formName);

            SetNumericUpDownValues();
        }

        private void SetNumericUpDownValues()
        {
            numWorkerCount.Maximum = new decimal(new int[] { (int)Production.MAX_EMPLOYEES_NUMBER, 0, 0, 0 });
            numWorkerCount.Minimum = new decimal(new int[] { (int)Production.MIN_EMPLOYEES_NUMBER, 0, 0, 0 });
            numWorkerCount.Value = new decimal(new int[] { (int)Production.MIN_EMPLOYEES_NUMBER, 0, 0, 0 });

            numId.Maximum = new decimal(new int[] { (int)Workshop.MAX_ID_NUMBER, 0, 0, 0 });
            numId.Minimum = new decimal(new int[] { (int)Workshop.MIN_ID_NUMBER, 0, 0, 0 });
            numId.Value = new decimal(new int[] { (int)Workshop.MIN_ID_NUMBER, 0, 0, 0 });
        }

        protected abstract void SaveBtn_Click(object sender, EventArgs e);

        protected virtual void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected virtual void scheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Shift>? shifts;
            List<ScheduleElement>? scheduleElements;

            switch (scheduleComboBox.SelectedIndex)
            {
                case 0:
                    scheduleDetails.Text = "Four-brigade schedule:" + Environment.NewLine +
                                         "4 days night, 2 off," + Environment.NewLine +
                                         "4 days day, 1 off...";

                    (shifts, scheduleElements) = StandardSchedules.ThreeShiftFourBrigade;
                    _workshop.Shifts = shifts;
                    _workshop.Schedule = scheduleElements;

                    break;

                case 1:
                    scheduleDetails.Text = "Five-brigade schedule:" + Environment.NewLine +
                                         "2 days day shift, 2 off," + Environment.NewLine +
                                         "2 days evening shift...";

                    (shifts, scheduleElements) = StandardSchedules.ThreeShiftFiveBrigade;
                    _workshop.Shifts = shifts;
                    _workshop.Schedule = scheduleElements;

                    break;

                default:
                    scheduleDetails.Text = "Select a schedule...";
                    break;
            }
        }


        protected bool ValidateAndSave()
        {
            var errors = new List<string>();

            var validations = new List<Action>
            {
                { () => _workshop.Name = txtProductionName.Text },
                { () => _workshop.Manager = txtManagerName.Text },
                { () => _workshop.WorkerCount = (uint)numWorkerCount.Value },
                { () => _workshop.Id = (uint)numId.Value }
            };

            foreach (var validation in validations)
            {
                try { validation(); }
                catch (ValidationException ex) { errors.Add(ex.Message); }
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        protected bool ValidateScheduleSelection()
        {
            if (scheduleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a schedule before proceeding.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        protected void EditList<T>(List<T> list, Action<List<T>> setList)
        {
            using (var editForm = new EditListForm<T>(list, setList))
            {
                if (editForm.ShowDialog() == DialogResult.OK) { }
            }
        }

        protected virtual void EditProductsBtn_Click(object sender, EventArgs e)
        {
            EditList(
                _workshop.ProductList,
                value => _workshop.ProductList = value
            );
        }

        protected virtual void EditBrigadesBtn_Click(object sender, EventArgs e)
        {
            EditList(
                _workshop.Brigades,
                value => _workshop.Brigades = value
            );
        }
    }
}
