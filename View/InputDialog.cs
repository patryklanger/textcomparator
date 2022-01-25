using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextComparatorGUI
{
    public partial class InputDialog : Form
    {
        public InputDialog()
        {
            InitializeComponent();
        }

        public static string ShowDialog(string content, string title)
        {
            var dialog = new InputDialog();
            dialog.Visible = false;
            dialog.Text = title;
            dialog.contentLabel.Text = content;
            dialog.okButton.DialogResult = DialogResult.OK;
            dialog.okButton.Click += (sender, e) => { dialog.Close(); };
            dialog.AcceptButton = dialog.okButton;
            return dialog.ShowDialog() == DialogResult.OK ? dialog.textBox.Text : "";
        }

        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void contentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
