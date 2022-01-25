using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileComparator;


namespace TextComparatorGUI
{
    public partial class Result : System.Windows.Forms.Form
    {
        public Difference previousForm;
        private Text resultText;
        private PrimaryFileWorker fileWorker;
        public Result(PrimaryFileWorker fileWorker)
        {
            this.fileWorker = fileWorker;
            InitializeComponent();
            saveFileDialog.Filter = "txt files (.txt)|.txt|All files (.)|.";
        }

        private void Result_Load(object sender, EventArgs e)
        {
        }

        private void fileCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        public void initialize(Text resultText)
        {
            this.resultText = resultText;
            this.resultTextBox.Text = "";
            resultTextBox.AppendText(resultText.Content);
            this.Show();
        }

        private void fileSave_Click(object sender, EventArgs e)
        {

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Task task = fileWorker.SaveFile(resultText, saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't open file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}