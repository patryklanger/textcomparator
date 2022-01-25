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
        public Result(Text resultText, PrimaryFileWorker fileWorker)
        {
            this.fileWorker = fileWorker;
            this.resultText = resultText;
            InitializeComponent();
            saveFileDialog.Filter = "txt files (.txt)|.txt|All files (.)|.";
        }

        private void Result_Load(object sender, EventArgs e)
        {
            resultTextBox.AppendText(resultText.Content);
        }

        private void fileCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void initialize()
        {

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