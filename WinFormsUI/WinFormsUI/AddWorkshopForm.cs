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
    public partial class AddWorkshopForm : WorkShopFormBase
    {
        public Workshop NewWorkshop => _workshop;
        private bool _productListEdited = false;
        private bool _brigadesEdited = false;

        public AddWorkshopForm() : base("Add Workshop")
        {
            _workshop = Workshop.CreateEmpty();
        }

        protected override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!_productListEdited || !_brigadesEdited)
            {
                MessageBox.Show("You must edit both the product list and the brigade list before saving!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateAndSave() || !ValidateScheduleSelection()) { return; }

            var result = MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected override void EditProductsBtn_Click(object sender, EventArgs e)
        {
            EditList(
                _workshop.ProductList,
                value =>
                {
                    if (value == null || value.Count == 0)
                    {
                        throw new InvalidOperationException("The list of brigades cannot be empty!");
                    }
                    _workshop.ProductList = value;
                    _productListEdited = true;
                }
            );
        }

        protected override void EditBrigadesBtn_Click(object sender, EventArgs e)
        {
            EditList(
                _workshop.Brigades,
                value =>
                {
                    if (value == null || value.Count == 0)
                    {
                        throw new InvalidOperationException("The list of brigades cannot be empty!");
                    }
                    _workshop.Brigades = value;
                    _brigadesEdited = true;
                }
            );
        }
    }
}
