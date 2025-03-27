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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsUI
{
    public partial class EditWorkshopForm : WorkShopFormBase
    {
        public Workshop EditedWorkshop => _workshop;

        public EditWorkshopForm(Workshop originalWorkshop) : base("Edit Workshop")
        {
            _workshop = new Workshop(originalWorkshop);

            txtProductionName.Text = _workshop.Name;
            txtManagerName.Text = _workshop.Manager;
            numWorkerCount.Value = _workshop.WorkerCount;
            numId.Value = _workshop.Id;
        }

        protected override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateAndSave()) { return; }

            var result = MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
