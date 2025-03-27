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

namespace WinFormsUI
{
    public partial class EditListForm<T> : EditListFormBase
    {
        private List<T> _originalList;
        private BindingList<T> _bindingList;
        private readonly Action<List<T>> _setList;

        public EditListForm(List<T> initialList, Action<List<T>> setList)
        {
            _setList = setList;
            _originalList = new List<T>(initialList);
            _bindingList = new BindingList<T>(initialList);

            listBoxItems.DataSource = _bindingList;
        }

        protected override void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewItem.Text)) { return; }

            try
            {
                T newItem = ParseItem(txtNewItem.Text);
                _bindingList.Add(newItem);
                txtNewItem.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void EditBtn_Click(object sender, EventArgs e)
        {
            int index = listBoxItems.SelectedIndex;
            if (index == -1) // If the item is not selected
            {
                return;
            }

            string input = txtEditItem.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            try
            {
                _bindingList[index] = ParseItem(input);
                txtEditItem.Clear(); // Clear the field after successful editing
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not edit item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem is T selectedItem && listBoxItems.SelectedIndex >= 0)
            {
                _bindingList.RemoveAt(listBoxItems.SelectedIndex);
            }
        }

        protected override void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _setList(new List<T>(_bindingList));
            }
            catch (ValidationException ex)
            {
                _setList(_originalList);
                MessageBox.Show(ex.Message, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected override void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private T ParseItem(string input)
        {
            if (typeof(T) == typeof(string))
            {
                return (T)(object)input;
            }

            // Use TypeConverter to support a wider range of types
            var converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter.CanConvertFrom(typeof(string)))
            {
                return (T)converter.ConvertFrom(input);
            }

            throw new InvalidOperationException($"Type {typeof(T).Name} does not support conversation from string.");
        }
    }
}
