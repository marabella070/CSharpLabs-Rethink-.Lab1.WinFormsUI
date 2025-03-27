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
    public abstract partial class EditListFormBase : Form
    {
        protected EditListFormBase()
        {
            InitializeComponent();
        }

        protected abstract void AddBtn_Click(object sender, EventArgs e);
        protected abstract void EditBtn_Click(object sender, EventArgs e);
        protected abstract void DeleteBtn_Click(object sender, EventArgs e);
        protected abstract void SaveBtn_Click(object sender, EventArgs e);
        protected abstract void CancelBtn_Click(object sender, EventArgs e);
    }
}
