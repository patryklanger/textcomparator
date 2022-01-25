using FileComparator;
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
    public partial class OpenFile : System.Windows.Forms.Form
    {
        public Difference nextForm;

        private Text firstText;
        private Text secondText;

        public PrimaryFileWorker fileWorker;
        public OpenFile(PrimaryFileWorker fileWorker)
        {
            this.fileWorker = fileWorker;
            InitializeComponent();
        }

        public void initialize()
        {
            firstText = null;
            secondText = null;
            firstFileTextBox.Text = null;
            secondFileTextBox.Text = null;
            compareButton.Enabled = false;
            this.Show();
        }
        
        private void compareButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstText = fileWorker.ReadFile(firstFileTextBox.Text);
                secondText = fileWorker.ReadFile(secondFileTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't open file!", "Error!", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            nextForm.initialize(firstText, secondText);
            this.Hide();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (sender.Equals(firstFileButton))
                { 
                    firstFileTextBox.Text = openFileDialog.FileName;
                }   
                else if (sender.Equals(secondFileButton))
                {
                    secondFileTextBox.Text = openFileDialog.FileName;
                }
            }

            if (String.IsNullOrEmpty(firstFileTextBox.Text) || String.IsNullOrEmpty(secondFileTextBox.Text))
                return;
            compareButton.Enabled = true;
        }
    }
}
